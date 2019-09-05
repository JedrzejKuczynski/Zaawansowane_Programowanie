using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZP_GA
{
    class Tests
    {
        List<int> fragments;
        List<int> samples;
        List<double> fills;

        List<int> pop_sizes;
        List<int> gens;
        List<double> crossing_overs;
        List<double> mutations;

        public Tests()
        {
            // Generator
            // m liczba fragmentów
            // n liczba próbek

            fragments = new List<int> { 10, 30, 50, 100, 150, 200, 250, 300, 400, 500 };
            samples = new List<int> { 10, 30, 50, 100, 150, 200, 250, 300, 400, 500 };
            fills = new List<double> { 0.1, 0.2, 0.3, 0.4, 0.5 };
            // Błędy dynamicznie CO Z NIMI??? OTO PYTANIE


            // Heurystyka

            pop_sizes = new List<int> { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 700, 1000 };
            gens = new List<int> { 50, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1500, 2000, 2500, 3000, 4000, 5000 };
            // Turniej dynamicznie 10%, 20%, 30%, 40%, 50% populacji???
            crossing_overs = new List<double> { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9 };
            mutations = new List<double> { 0, 0.02, 0.04, 0.06, 0.08, 0.1 };



        }

        public void run_tests()
        {
            string current_dir = @"C:\Users\Jędrzej\Desktop\Studium_Naturae\Zaawansowane_Programowanie\ZP_GA\ZP_GA";
            string file_path = current_dir + Path.DirectorySeparatorChar + "Testy" + Path.DirectorySeparatorChar + "testy.csv";
            string header = "Fragments;Samples;Fill;Errors;Pop_Size;Gens;Tour_Size;CO;Mut;No;Fitness;Time[s]";

            using (StreamWriter sw = new StreamWriter(file_path, true))
                sw.WriteLine(header);

                for (int m = 0; m < fragments.Count; m++)
                    for (int n = 0; n < samples.Count; n++)
                    {
                        int current_fragments = fragments[m];
                        int current_samples = samples[n];

                        for (int f = 0; f < fills.Count; f++)
                        {
                            double current_fill = fills[f];
                            List<int> errors = new List<int>();

                            int max_errors = (current_fragments * current_samples) / 5;
                            float error_increment = max_errors / 5;
                            float number_of_errors = 0;
                            errors.Add(Convert.ToInt32(number_of_errors));

                            for (int inc = 0; inc < 5; inc++)
                            {
                                number_of_errors += error_increment;
                                errors.Add(Convert.ToInt32(number_of_errors));
                            }

                            for (int e = 0; e < errors.Count; e++)
                                for (int p = 0; p < pop_sizes.Count; p++)
                                {
                                    if (pop_sizes[p] <= current_samples * 10)
                                    {
                                        int current_errors = errors[e];
                                        int pop_size = pop_sizes[p];
                                        List<int> tournament_sizes = new List<int> { Convert.ToInt32(pop_size*0.1), Convert.ToInt32(pop_size*0.2),
                                                                                        Convert.ToInt32(pop_size*0.3), Convert.ToInt32(pop_size*0.4),
                                                                                        Convert.ToInt32(pop_size*0.5) };

                                        for (int g = 0; g < gens.Count; g++)
                                            if(gens[g] <= (current_fragments+current_samples)*10)
                                                for (int t = 0; t < tournament_sizes.Count; t++)
                                                    for (int cv = 0; cv < crossing_overs.Count; cv++)
                                                        for (int mut = 0; mut < mutations.Count; mut++)
                                                        {
                                                            int current_gens = gens[g];
                                                            int current_tournament = tournament_sizes[t];
                                                            double current_cv = crossing_overs[cv];
                                                            double current_mut = mutations[mut];

                                                            string line_template = "{0};{1};{2};{3};{4};{5};{6};{7};{8};";
                                                            string line = string.Format(line_template, current_fragments, current_samples, current_fill, current_errors, pop_size, current_gens, current_tournament, current_cv, current_mut);

                                                            Console.WriteLine("\n\nTworzę plik!!! PARAMETRY:\nFragmenty:" + current_fragments + " Próbki: " + current_samples + " FILL: " + current_fill + " ERRORS: " + current_errors + " POP: " + pop_size + " GENS: " + current_gens + " TOURNAMENT: " + current_tournament + " CO: " + current_cv + " MUT:" + current_mut);

                                                            for (int i = 0; i < 10; i++)
                                                            {
                                                                DataTable new_instance = Generator.Create(current_fragments, current_samples, current_fill, current_errors).Instance.Copy();

                                                                Stopwatch stopwatch = Stopwatch.StartNew();
                                                                GA ga = new GA(new_instance.Copy(), pop_size, current_gens, 0, 0, current_tournament, current_cv, current_mut);
                                                                ga.life_uh_finds_a_way();
                                                                stopwatch.Stop();

                                                                var time = stopwatch.ElapsedMilliseconds;

                                                                Console.WriteLine("INSTANCJA: " + i + "; WARTOŚĆ: " + ga.Best.Fitness + " CZAS W SEKUNDACH: " + time * 0.001);

                                                                using (StreamWriter sw = new StreamWriter(file_path, true))
                                                                    sw.WriteLine(line + i + ";" + ga.Best.Fitness + ";" + time * 0.001);
                                                            }

                                                        }
                                    }
                                }
                        }
                    }
        }
    }
}
