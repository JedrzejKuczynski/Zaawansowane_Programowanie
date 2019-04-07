using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZP_GA
{
    class Generator
    {

        // musi byc tutaj, poniewaz Random i Clock i te sprawy
        private static Random random = new Random(); // potrzebne do wypelniania wierszy
        private DataTable instance;
        private List<Tuple<int, int>> indices;

        public DataTable Instance { get { return instance; } }

        public List<Tuple<int, int>> Indices { get { return indices; } }

        // m liczba fragmentów
        // n liczba próbek
        // fill poziom wypelnienia wiersza
        // errors liczba błędów

        public Generator(int m, int n, double fill, int errors)
        {
            instance = new DataTable("Instancja");

            for (int i = 0; i < n; i++) // wypelnianie kolumnami reprezentujacymi probki
            {
                DataColumn new_column = new DataColumn("s" + i);
                new_column.DataType = System.Type.GetType("System.Int32"); // Typ danych, oszczedzi zachodu przy sprawdzaniu
                instance.Columns.Add(new_column);
            }

            // obliczanie maksymalnej ilosci 1 w wierszu
            int threshold = Convert.ToInt32(Math.Ceiling(instance.Columns.Count * fill));

            if (threshold < 1)
                threshold = 1;

            for(int i = 0; i < m; i++)
            {
                DataRow new_row = instance.NewRow();
                int number_of_ones = random.Next(1, threshold + 1); // liczba jedynek
                int start_point = random.Next(instance.Columns.Count - number_of_ones + 1); // odpowiedni start

                for (int j = 0; j < instance.Columns.Count; j++) // wypelnianie zerami
                    new_row[j] = 0;

                while(number_of_ones > 0) // wypelnianie consecutive ones
                {
                    new_row[start_point] = 1;
                    start_point++;
                    number_of_ones--;
                }

                instance.Rows.Add(new_row); // dodawanie do DataTable
            }

            // lista przechowujaca uzyte indeksy do wprowadzania bledow
            indices = new List<Tuple<int, int>>();

            for(int i = 0; i < errors; i++) // wprowadzanie bledow
            {
                int row_index = random.Next(instance.Rows.Count); // losowanie wiersza
                int column_index = random.Next(instance.Columns.Count); // losowanie kolumny

                Tuple<int, int> used = Tuple.Create(row_index, column_index); // tworzenie krotki indeksow do powyzszej listy

                if (!indices.Contains(used)) // jezeli blad nie byl wprowadzany w tej komorce
                {
                    if (Convert.ToInt32(instance.Rows[row_index][column_index]) == 1) // odpowiednio go wprowadz
                        instance.Rows[row_index][column_index] = 0;
                    else
                        instance.Rows[row_index][column_index] = 1;

                }

                indices.Add(used); // dodaj na liste uzytych
            }

        }

    }
}
