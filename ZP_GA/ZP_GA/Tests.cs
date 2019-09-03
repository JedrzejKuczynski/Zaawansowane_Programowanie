using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZP_GA
{
    class Tests
    {
        // TO TRZA WPIERDZIELIĆ W FUNKCJĘ. MOŻE???
        public Tests()
        {
            // Generator
            // m liczba fragmentów
            // n liczba próbek

            List<int> fragments = new List<int> { 5, 10, 20, 30, 40, 50, 80, 100, 120, 150, 200, 250, 300 };
            List<int> samples = new List<int> { 5, 10, 20, 30, 40, 50, 80, 100, 120, 150, 200, 250, 300 };
            List<int> fills = new List<int> { 10, 20, 30, 40, 50 };
            // Błędy dynamicznie CO Z NIMI??? OTO PYTANIE


            // Heurystyka

            List<int> pop_sizes = new List<int> { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500 };
            List<int> gens = new List<int> { 50, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1500, 2000, 2500, 3000, 3500, 4000, 4500, 5000 };
            // Turniej dynamicznie 10%, 20%, 30%, 40%, 50% populacji???
            List<int> crossing_overs = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            List<int> mutations = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            for(int m = 0; m < fragments.Count; m++)
                for(int n = 0; n < samples.Count; n++)
                {
                    Directory.CreateDirectory("Testy" + Path.DirectorySeparatorChar + fragments[m] + "_" + samples[n]);

                    for (int f = 0; f < fills.Count; f++)
                    {
                        List<int> errors = new List<int>();

                        // TU BŁĘDY JAKOŚ UMIEJĘTNIE

                        for(int e = 0; e < errors.Count; e++)
                            for (int p = 0; p < pop_sizes.Count; p++)
                                for (int g = 0; g < gens.Count; g++)
                                {
                                    int pop_size = pop_sizes[p];
                                    List<int> tournament_sizes = new List<int> { Convert.ToInt32(pop_size*0.1), Convert.ToInt32(pop_size*0.2),
                                                                                    Convert.ToInt32(pop_size*0.3), Convert.ToInt32(pop_size*0.4),
                                                                                    Convert.ToInt32(pop_size*0.5) };

                                    for (int t = 0; t < tournament_sizes.Count; t++)
                                        for (int cv = 0; cv < crossing_overs.Count; cv++)
                                            for (int mut = 0; mut < mutations.Count; mut++)
                                            {
                                                // TU TWORZENIE PLIKU
                                                Console.WriteLine("Tworzę plik!!! PARAMETRY: Fragmenty:" + m + " Próbki: " + n + " POP: " + p + " GENS: " + g + " TOURNAMENT: " + t + " CO: " + cv + " MUT:" + mut);
                                                for (int i = 0; i < 10; i++)
                                                {
                                                    // DataTable new_instance = Generator.Create(fragments[m], samples[n], fills[f], errors[e]).Instance;
                                                    // GA ga = new GA(new_instance.Copy(), pop_size, gens[g], 0, 0, tournament_sizes[t], crossing_overs[cv], mutations[mut]);
                                                    // MIERZENIE CZASU I WARTOŚCI FUNKCJI
                                                    // ga.life_uh_finds_a_way();
                                                    // JAKIŚ CONSOLE.WRITELINE()
                                                    Console.WriteLine("ELO INSTANCJA: " + i);
                                                    // I DODANIE DO PLIKU
                                                }

                                            }
                                }
                    }
                }
        }
    }
}
