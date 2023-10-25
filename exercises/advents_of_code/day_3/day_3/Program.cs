using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_of_code_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_to_find, distance_manhattan_metric;
            int in_which_step = 0;
            int how_many_steps = 1;

            Console.WriteLine("Program mierzy odległość od podanej do Ciebie liczby do punktu startowego (1) według metryki Manhattan. " +
                "\nPodaj swoją liczbę: ");
            number_to_find = Convert.ToInt32(Console.ReadLine());

           number_to_find = number_to_find - 1; //start
           while(true)
            {
                //go_right
                number_to_find = number_to_find - how_many_steps; 
                if (number_to_find == 0)
                {
                    in_which_step = how_many_steps;
                    distance_manhattan_metric = (how_many_steps / 2) + Math.Abs((how_many_steps / 2) - in_which_step);

                    break;  
                }

                if (number_to_find < 0)
                {
                    in_which_step = how_many_steps + number_to_find;
                    if ( in_which_step == (how_many_steps / 2) )
                    {
                        distance_manhattan_metric = in_which_step;
                    }
                    else
                    {
                        distance_manhattan_metric = (how_many_steps / 2) + Math.Abs((how_many_steps / 2) - in_which_step);
                    }

                    break;  //zapamiętaj how_many_steps + in_which_step
                }

                //go_up
                number_to_find = number_to_find - how_many_steps;
                if (number_to_find == 0)
                {
                    in_which_step = how_many_steps;
                    distance_manhattan_metric = (how_many_steps / 2) + Math.Abs((how_many_steps / 2) - in_which_step);

                    break;
                }

                if (number_to_find < 0)
                {
                    in_which_step = how_many_steps + number_to_find;
                    if (in_which_step == (how_many_steps / 2))
                    {
                        distance_manhattan_metric = in_which_step;
                    }
                    else
                    {
                        distance_manhattan_metric = (how_many_steps / 2) + Math.Abs((how_many_steps / 2) - in_which_step);
                    }

                    break;  //zapamiętaj how_many_steps + in_which_step
                }

                //go_left
                how_many_steps = how_many_steps + 1;
                number_to_find = number_to_find - how_many_steps;
                if (number_to_find == 0)
                {
                    in_which_step = how_many_steps;
                    distance_manhattan_metric = (how_many_steps / 2) + Math.Abs((how_many_steps / 2) - in_which_step);

                    break;
                }

                if (number_to_find < 0)
                {
                    in_which_step = how_many_steps + number_to_find;
                    if (in_which_step == (how_many_steps / 2))
                    {
                        distance_manhattan_metric = in_which_step;
                    }
                    else
                    {
                        distance_manhattan_metric = (how_many_steps / 2) + Math.Abs((how_many_steps / 2) - in_which_step);
                    }

                    break;  //zapamiętaj how_many_steps + in_which_step
                }

                //go_down
                number_to_find = number_to_find - how_many_steps;
                if (number_to_find == 0)
                {
                    in_which_step = how_many_steps;
                    distance_manhattan_metric = (how_many_steps / 2) + Math.Abs((how_many_steps / 2) - in_which_step);

                    break;
                }

                if (number_to_find < 0)
                {
                    in_which_step = how_many_steps + number_to_find;
                    if (in_which_step == (how_many_steps / 2))
                    {
                        distance_manhattan_metric = in_which_step;
                    }
                    else
                    {
                        distance_manhattan_metric = (how_many_steps / 2) + Math.Abs((how_many_steps / 2) - in_which_step);
                    }

                    break;  //zapamiętaj how_many_steps + in_which_step
                }

                how_many_steps++;
            }


            Console.WriteLine("{0}, {1}, {2}, {3}", number_to_find, how_many_steps, in_which_step, distance_manhattan_metric);
            Console.ReadKey();
        }


        /*Ten kod czeka na refaktoryzację
         
          number_to_find -= 1; //start
            while (true)
            {
                number_to_find = go_right(how_many_steps, number_to_find); //go_right i go_up przy tworzeniu spirali ulama zawsze przesuwają się o tą samą liczbę pól + zawsze są o 1 mniejsze od dwóch kolejnych ruchów
                check(number_to_find);

                number_to_find = go_up( how_many_steps, number_to_find );
                check(number_to_find);

                number_to_find = go_left( how_many_steps + 1, number_to_find );
                check(number_to_find);

                number_to_find = go_down(how_many_steps + 1, number_to_find);
                check(number_to_find);

                how_many_steps += 1; 
            }
        static int go_right(int how_many_steps, int number_to_fo_find)
        {
            number_to_fo_find -= how_many_steps;     
            return number_to_fo_find;
        }


        static int go_up(int how_many_steps, int number_to_find)
        {
            number_to_find -= how_many_steps;
            return number_to_find;
        }

        static int go_left(int how_many_steps, int number_to_find)
        {
            number_to_find -= how_many_steps;
            return number_to_find;
        }

        static int go_down(int how_many_steps, int number_to_find)
        {
            number_to_find -= how_many_steps;
            return number_to_find;
        }

        static int[] chceck(int number_to_find)
        {
            if (number_to_find > 0)
            {
                int[]
            }
            if (number_to_find == 0);
            {

            }
            if (number_to_find < 0);
            {

            }
            return;
        }
        */

    }
}
