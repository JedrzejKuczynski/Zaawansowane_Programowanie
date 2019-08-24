using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZP_GA
{
    class Individual
    {
        private DataTable solution;
        private List<string> genome;
        private int fitness;

        public DataTable Solution
        {
            get
            {
                return solution;
            }
        }

        public List<string> Genome
        {
            get
            {
                return genome;
            }
        }

        public int Fitness
        {
            get
            {
                return fitness;
            }
        }

        public void set_genome_order(List<string> order)
        {
            int column_index = 0;

            foreach(string column_name in order)
            {
                solution.Columns[column_name].SetOrdinal(column_index);
                column_index++;
            }
        }

        public void calculate_fitness()
        {

            foreach(DataRow row in solution.Rows)
            {
                string binary_string = string.Join("", row.ItemArray);
                binary_string = binary_string.Trim('0');

                List<int> sequence = new List<int>();

                int zeros_counter = 0;
                int ones_counter = 0;

                for(int i = 0; i < binary_string.Length; i++)
                {
                    if(binary_string[i] == '1')
                    {
                        ones_counter++;

                        if(zeros_counter > 0)
                        {
                            sequence.Add(zeros_counter);
                            zeros_counter = 0;
                        }
                    }
                    else
                    {
                        zeros_counter++;

                        if(ones_counter > 0)
                        {
                            sequence.Add(ones_counter);
                            ones_counter = 0;
                        }
                    }
                }

                if (sequence.Count > 1)
                {
                    for (int i = 0; i < sequence.Count; i += 2)
                    {
                        if (i + 1 < sequence.Count)
                        {
                            int ones_number = sequence[i];
                            int zeros_number = sequence[i + 1];

                            if (ones_number <= zeros_number)
                                fitness += ones_number;
                            else
                                fitness += zeros_number;
                        }
                    }
                }
            }
        }

        public Individual(DataTable matrix, List<string> order)
        {
            solution = matrix;
            genome = order;
            fitness = 0;
            set_genome_order(genome);
        }
    }
}
