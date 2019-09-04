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
        private List<Tuple<int, int>> cells;

        public DataTable Instance { get { return instance; } }

        public List<Tuple<int, int>> Indices { get { return indices; } }

        // m liczba fragmentów
        // n liczba próbek
        // fill poziom wypelnienia wiersza
        // errors liczba błędów

        public static Generator Create(int m, int n, double fill, int errors)
        {
            // I tak się przyda przy testach
            // int possible_errors = n / 2;
            // possible_errors *= m / 2;

            return new Generator(m, n, fill, errors);
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
            cells = new List<Tuple<int, int>>();

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
                {
                    Tuple<int, int> new_cell = new Tuple<int, int>(i, j);
                    cells.Add(new_cell);
                    new_row[j] = 0;
                }

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

            while (cells.Count > 0 && errors_counter < errors) // wprowadzanie bledow
            {
                int cell_index = random.Next(cells.Count);
                Tuple<int, int> cell = cells[cell_index];
                cells.RemoveAt(cell_index);
                int row_index = cell.Item1;
                int column_index = cell.Item2;

                // DataRow current_row = instance.Rows[row_index];

                if (column_index + 1 >= instance.Columns.Count) // jesteśmy na prawym skrajnym
                {
                    if (Convert.ToInt32(instance.Rows[row_index][column_index - 1]) == 0 && Convert.ToInt32(instance.Rows[row_index][column_index]) == 0)
                    {
                        Tuple<int, int> used = Tuple.Create(row_index, column_index);

                        instance.Rows[row_index][column_index] = 1;
                        errors_counter++;
                        indices.Add(used);
                    }
                }
                else if (column_index - 1 < 0) // jesteśmy na lewym skrajnym
                {
                    if (Convert.ToInt32(instance.Rows[row_index][column_index + 1]) == 0 && Convert.ToInt32(instance.Rows[row_index][column_index]) == 0)
                    {
                        Tuple<int, int> used = Tuple.Create(row_index, column_index);

                        instance.Rows[row_index][column_index] = 1;
                        errors_counter++;
                        indices.Add(used);
                    }
                }
                else // jesteśmy w środku
                {
                    string configuration = string.Join("", instance.Rows[row_index].ItemArray);
                    configuration = configuration.Substring(column_index - 1, 3);

                    if (configuration == "111")
                    {
                        Tuple<int, int> used = Tuple.Create(row_index, column_index);

                        instance.Rows[row_index][column_index] = 0;
                        errors_counter++;
                        indices.Add(used);
                    }
                    else if (configuration == "000")
                    {
                        Tuple<int, int> used = Tuple.Create(row_index, column_index);

                        instance.Rows[row_index][column_index] = 1;
                        errors_counter++;
                        indices.Add(used);
                    }
                }
            }

            // MessageBox.Show("Wprowadzono " + errors_counter + " błędów z " + errors + "."); ODKOMENTOWAĆ PO TESTACH
        }
            
    }
}
