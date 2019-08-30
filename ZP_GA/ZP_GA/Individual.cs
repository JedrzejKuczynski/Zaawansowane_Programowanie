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

        public void set_genome_order()
        {
            int column_index = 0;

            foreach(string column_name in genome)
            {
                solution.Columns[column_name].SetOrdinal(column_index);
                column_index++;
            }
        }

        public void calculate_fitness()
        {
            int calculated_fitness = 0;

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

                        if(i == binary_string.Length - 1)
                            sequence.Add(ones_counter);
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
                                calculated_fitness += ones_number;
                            else
                                calculated_fitness += zeros_number;
                        }
                        else
                        {
                            int last_ones = sequence[i];
                            int zeros_number = sequence[i - 1];
                            int previous_ones = sequence[i - 2];

                            if(last_ones < zeros_number)
                            {
                                if(zeros_number > previous_ones)
                                {
                                    if (last_ones < previous_ones)
                                    {
                                        calculated_fitness -= previous_ones;
                                        calculated_fitness += last_ones;
                                    }
                                }
                                else
                                {
                                    int difference = zeros_number - last_ones;
                                    calculated_fitness -= difference;
                                }
                            }
                        }
                    }
                }
            }

            fitness = calculated_fitness;
        }

        public Individual(DataTable matrix, List<string> order)
        {
            solution = matrix;
            genome = order;
            fitness = 0;
            set_genome_order();
        }
    }
}
