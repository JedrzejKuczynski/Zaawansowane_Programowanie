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

        }

        public Individual(DataTable matrix, List<string> order)
        {
            solution = matrix;
            genome = order;

            set_genome_order(genome);
            calculate_fitness();
        }
    }
}
