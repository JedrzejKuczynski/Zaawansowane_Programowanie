using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZP_GA
{
    // Tasowanie Fisher'a-Yates'a z modyfikacją Durstenfeld'a
    // Nie znalazłem lepszego pomysłu/sposobu na przetasowanie listy
    static class ShuffleExtension
    {
        private static Random random_shuffle = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            for (int i = list.Count; i > 1; i--)
            {
                int j = random_shuffle.Next(i);
                T value = list[j];
                list[j] = list[i];
                list[i] = value;
            }
        }
    }

    class GA
    {
        private static Random random = new Random();

        private readonly DataTable original_instance;

        private List<Individual> population;
        private List<int> individuals_fitness;

        private Individual best_individual;
        private int population_size;
        private int generations;
        private int time_threshold;
        private int iterations_threshold;
        private int tournament_size;
        private float crossing_probability;
        private float mutation_probability;

        public GA(DataTable instance, int pop_size, int gens, int time, int iterations, int tournament, float cross, float mut)
        {
            original_instance = instance;
            population_size = pop_size;
            generations = gens;
            time_threshold = time;
            iterations_threshold = iterations;
            tournament_size = tournament;
            crossing_probability = cross;
            mutation_probability = mut;

            // inicjalizacja populacji

            for (int i = 0; i < population_size; i++)
            {
                List<string> random_order = get_random_order();
                Individual new_individual = new Individual(original_instance, random_order);
                new_individual.calculate_fitness();
                population.Add(new_individual);
                individuals_fitness.Add(new_individual.Fitness);
            }

            best_individual = population[individuals_fitness.IndexOf(individuals_fitness.Min())];
        }

        // No nie znalazlem jakiejs biblioteki
        List<string> get_random_order()
        {
            HashSet<string> random_order_hash = new HashSet<string>();
            List<string> column_names = new List<string>();

            foreach (DataColumn column in original_instance.Columns)
                column_names.Add(column.ColumnName);

            for (int i = 0; i < column_names.Count; i++)
                while (!random_order_hash.Add(column_names[random.Next(column_names.Count)]));

            List<string> random_order_list = random_order_hash.ToList();

            return random_order_list;
        }

        List<Individual> selection(List<Individual> pop)
        {
            List<Individual> selected = new List<Individual>();

            for(int i = 0; i < population_size; i++)
            {
                HashSet<Individual> tournament = new HashSet<Individual>();

                for (int t = 0; t < tournament_size; t++)
                    while (!tournament.Add(pop[random.Next(population_size)]));

                Individual tournament_winner = tournament.OrderBy(participant => participant.Fitness).First();  // Spoko sprawa ten LINQ
                selected.Add(tournament_winner);
            }

            return selected;
        }

        List<Individual> crossing_over(List<Individual> selected)
        {
            List<Individual> new_population = new List<Individual>();

            List<Tuple<Individual, Individual>> parents = new List<Tuple<Individual, Individual>>();
            List<int> indices = Enumerable.Range(0, population_size).ToList();
            indices.Shuffle();

            for (int i = 0; i < population_size; i += 2)
            {
                Individual parent1 = selected[indices[i]];
                Individual parent2 = selected[indices[i + 1]];

                Tuple<Individual, Individual> pair = new Tuple<Individual, Individual>(parent1, parent2);
                parents.Add(pair);
            }

            foreach(Tuple<Individual, Individual> pair in parents)
            {
                if(random.NextDouble() <= crossing_probability)
                {
                    // TUTAJ KRZYŻOWANIE Z ZACHOWANIEM PORZĄDKU
                }
                else
                {
                    new_population.Add(pair.Item1);
                    new_population.Add(pair.Item2);
                }
            }
            

            return new_population;
        }

        // Główna pętla - tu się dzieje magia!!!
        // Trochę się powtarza, ale co tam. Lepszego pomysłu nie mam
        public void life_uh_finds_a_way()
        {
            if (time_threshold > 0 && iterations_threshold > 0)
            {
                float running_time = time_threshold * 60000;
                Individual previous_individual = best_individual;
                int iteration_counter = 0;

                for(int g = 0; g < generations; g++)
                {
                    Stopwatch iteration = Stopwatch.StartNew();

                    if (iteration_counter < iterations_threshold)
                    {

                        // Na razie tak. Zobaczymy co potem z ta sychronizacja
                        if (best_individual.Fitness == 0 || running_time <= 0)
                            return;

                        List<Individual> selected_individuals = selection(population);
                        population = crossing_over(selected_individuals);
                        population = mutation(population);

                        individuals_fitness.Clear();

                        foreach (Individual individual in population)
                        {
                            individual.calculate_fitness();
                            individuals_fitness.Add(individual.Fitness);
                        }

                        Individual candidate_individual = population[individuals_fitness.IndexOf(individuals_fitness.Min())];

                        if (candidate_individual.Fitness < best_individual.Fitness)
                        {
                            previous_individual = best_individual;
                            best_individual = candidate_individual;
                            iteration_counter = 0;
                        }

                        if (best_individual.Fitness == previous_individual.Fitness)
                            iteration_counter++;

                        iteration.Stop();
                        running_time -= iteration.ElapsedMilliseconds;
                    }
                    else
                        return;
                }

            } else if(time_threshold > 0)
            {
                float running_time = time_threshold * 60000;

                for(int g = 0; g < generations; g++)
                {
                    Stopwatch iteration = Stopwatch.StartNew();

                    // Na razie tak. Zobaczymy co potem z ta sychronizacja
                    if (best_individual.Fitness == 0 || running_time <= 0)
                        return;

                    List<Individual> selected_individuals = selection(population);
                    population = crossing_over(selected_individuals);
                    population = mutation(population);

                    individuals_fitness.Clear();

                    foreach (Individual individual in population)
                    {
                        individual.calculate_fitness();
                        individuals_fitness.Add(individual.Fitness);
                    }

                    Individual candidate_individual = population[individuals_fitness.IndexOf(individuals_fitness.Min())];

                    if (candidate_individual.Fitness < best_individual.Fitness)
                        best_individual = candidate_individual;

                    iteration.Stop();
                    running_time -= iteration.ElapsedMilliseconds;
                }
            } else if(iterations_threshold > 0)
            {
                Individual previous_individual = best_individual;
                int iteration_counter = 0;

                for(int g = 0; g < generations; g++)
                {
                    if (iteration_counter < iterations_threshold)
                    {
                        // Na razie tak. Zobaczymy co potem z ta sychronizacja
                        if (best_individual.Fitness == 0)
                            return;

                        List<Individual> selected_individuals = selection(population);
                        population = crossing_over(selected_individuals);
                        population = mutation(population);

                        individuals_fitness.Clear();

                        foreach (Individual individual in population)
                        {
                            individual.calculate_fitness();
                            individuals_fitness.Add(individual.Fitness);
                        }

                        Individual candidate_individual = population[individuals_fitness.IndexOf(individuals_fitness.Min())];

                        if (candidate_individual.Fitness < best_individual.Fitness)
                        {
                            previous_individual = best_individual;
                            best_individual = candidate_individual;
                            iteration_counter = 0;
                        }

                        if (best_individual.Fitness == previous_individual.Fitness)
                            iteration_counter++;
                    }
                    else
                        return;
                }
            }
            else
            {
                for(int g = 0; g < generations; g++)
                {

                    // Na razie tak. Zobaczymy co potem z ta sychronizacja
                    if (best_individual.Fitness == 0)
                        return;

                    List<Individual> selected_individuals = selection(population);
                    population = crossing_over(selected_individuals);
                    population = mutation(population);

                    individuals_fitness.Clear();

                    foreach (Individual individual in population)
                    {
                        individual.calculate_fitness();
                        individuals_fitness.Add(individual.Fitness);
                    }

                    Individual candidate_individual = population[individuals_fitness.IndexOf(individuals_fitness.Min())];

                    if (candidate_individual.Fitness < best_individual.Fitness)
                        best_individual = candidate_individual;
                }
            }
        }

    }
}
