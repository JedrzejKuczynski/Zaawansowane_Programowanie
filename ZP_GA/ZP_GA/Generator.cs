using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static Generator Create(int m, int n, double fill, int errors)
        {
            int possible_errors = n / 2;
            possible_errors *= m / 2;

            if (possible_errors >= errors)
                return new Generator(m, n, fill, errors);
            else
            {
                MessageBox.Show("Liczba błędów, które mają być wprowadzone przekracza oszacowaną liczbę błędów!!! Oszacowanie: " + possible_errors);
                return null;
            }
        }

        public Generator(int m, int n)
        {
            instance = new DataTable("Instancja");

            for (int i = 0; i < n; i++)
            {
                DataColumn new_column = new DataColumn("s" + i);
                new_column.DataType = System.Type.GetType("System.Int32");
                instance.Columns.Add(new_column);
            }

            for(int i = 0; i < m; i++)
            {
                DataRow new_row = instance.NewRow();

                for (int j = 0; j < instance.Columns.Count; j++)
                    new_row[j] = 0;

                instance.Rows.Add(new_row);
            }
        }

        private Generator(int m, int n, double fill, int errors)
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

            int errors_counter = 0;

            while (errors_counter < errors) // wprowadzanie bledow
            {
                bool chosen = false;

                while (!chosen)
                {
                    int row_index = random.Next(instance.Rows.Count); // losowanie wiersza
                    int column_index = random.Next(instance.Columns.Count); // losowanie kolumny

                    // DataRow current_row = instance.Rows[row_index];

                    if (column_index + 1 >= instance.Columns.Count) // jesteśmy na prawym skrajnym
                    {
                        if (Convert.ToInt32(instance.Rows[row_index][column_index - 1]) == 0 && Convert.ToInt32(instance.Rows[row_index][column_index]) == 0)
                        {
                            Tuple<int, int> used = Tuple.Create(row_index, column_index);

                            if (!indices.Contains(used))
                            {
                                instance.Rows[row_index][column_index] = 1;
                                errors_counter++;
                                indices.Add(used);
                                chosen = true;
                            }
                        }
                    }
                    else if (column_index - 1 < 0) // jesteśmy na lewym skrajnym
                    {
                        if (Convert.ToInt32(instance.Rows[row_index][column_index + 1]) == 0 && Convert.ToInt32(instance.Rows[row_index][column_index]) == 0)
                        {
                            Tuple<int, int> used = Tuple.Create(row_index, column_index);

                            if (!indices.Contains(used))
                            {
                                instance.Rows[row_index][column_index] = 1;
                                errors_counter++;
                                indices.Add(used);
                                chosen = true;
                            }
                        }
                    }
                    else // jesteśmy w środku
                    {
                        string configuration = string.Join("", instance.Rows[row_index].ItemArray);
                        configuration = configuration.Substring(column_index - 1, 3);

                        if (configuration == "111")
                        {
                            Tuple<int, int> used = Tuple.Create(row_index, column_index);

                            if (!indices.Contains(used))
                            {
                                instance.Rows[row_index][column_index] = 0;
                                errors_counter++;
                                indices.Add(used);
                                chosen = true;
                            }
                        }
                        else if (configuration == "000")
                        {
                            Tuple<int, int> used = Tuple.Create(row_index, column_index);

                            if (!indices.Contains(used))
                            {
                                instance.Rows[row_index][column_index] = 1;
                                errors_counter++;
                                indices.Add(used);
                                chosen = true;
                            }
                        }
                    }
                }
            }
        }
            
    }
}
