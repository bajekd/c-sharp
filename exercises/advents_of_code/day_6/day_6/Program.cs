using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2017_day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, max_index, ile_razy;
            int total_count = 0;
            int how_many_arrays = 0;
            int[] input = { 0,2,7,0 };
            int[,] saved_arrays = new int[300, 4]; // znajdź lepsze rozwiązanie
            bool to_continue = true;


            while (to_continue)
            {
                total_count++;
                how_many_arrays++;
                
                //saving array to compare them later
                if ((how_many_arrays == 1) && (total_count == 1)) //umożliwienie zapisu w pierwszej iteracji pętli - DO ZMIANY!
                {
                    how_many_arrays = 0;
                }
                for (int i = 0; i < input.Length; i++)
                {
                    saved_arrays[how_many_arrays, i] = input[i];
                }

                //search_first_max
                max = input[0];
                max_index = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > max)
                    {
                        max = input[i];
                        max_index = i;
                    }
                }

                //divide && redistribution
                int temporary_max = max;
                int temporary_max_index = max_index;


                ile_razy = temporary_max / (input.Length - 1);

                    while ( ile_razy > 0)
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (i != max_index)
                            {
                                input[i] += 1;
                            }
                        }
                        temporary_max = temporary_max % (input.Length - 1);
                        input[max_index] = temporary_max;
                        ile_razy--;
                    }
                    
                        while(temporary_max > 0)
                        {
                            if(temporary_max_index == input.Length - 1)
                            {
                                temporary_max_index = 0;
                                input[temporary_max_index] += 1;
                                temporary_max--;
                                input[max_index] = temporary_max; ;
                            }
                            else
                            {
                                temporary_max_index++;
                                input[temporary_max_index] += 1;
                                temporary_max--;
                                input[max_index] = temporary_max;
                            }
                            
                        }

                //comparsion
                int indeks_inputu = 0;
                int czy_tablica_jest_ta_sama = 0;
                for(int i = 0; i < 300; i++)
                {
                    for(int j = 0; j < input.Length; j++)
                    {
                        indeks_inputu = j;
                        if(saved_arrays[i,j] == input[indeks_inputu])
                        {
                            czy_tablica_jest_ta_sama++;
                        }

                        if(czy_tablica_jest_ta_sama == 4)
                        {
                            to_continue = false;
                        }

                    }

                    czy_tablica_jest_ta_sama = 0;
                }
            }

            Console.WriteLine(total_count);
            Console.ReadKey();

        }

    }
}

       

    

            

                    
           

           
