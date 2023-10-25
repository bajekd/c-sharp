using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path_of_file = @"C:\Users\Blaise\source\repos\Advent_of_code_2017\Advent_of_code_day_5\Advent_of_code_day_5.txt";
            how_many_steps(path_of_file);
            how_many_steps_part_2(path_of_file);

            Console.ReadKey();
        }

        static void how_many_steps(string path_of_file)
        {
            string[] input = File.ReadAllLines(path_of_file);
            int[] input_int = Array.ConvertAll(input, s => int.Parse(s));

            int total_number_of_steps = 0, current_position = 0, how_many_steps = 0;
   
            while(true)
                try
                {
                    {
                        total_number_of_steps++; //start

                        how_many_steps = input_int[current_position];
                        input_int[current_position]++;

                        current_position += how_many_steps; 

                        if( (current_position < 0) || (current_position >= input_int.Length) )
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(total_number_of_steps);
                    break;
                }
        }

        static void how_many_steps_part_2(string path_of_file)
        {
            string[] input = File.ReadAllLines(path_of_file);
            int[] input_int = Array.ConvertAll(input, s => int.Parse(s));

            int total_number_of_steps = 0, current_position = 0, how_many_steps = 0;

            while (true)
                try
                {
                    {
                        total_number_of_steps++; //start

                        how_many_steps = input_int[current_position];
                        if( input_int[current_position] >= 3 )
                        {
                            input_int[current_position]--;
                        }
                        else
                        {
                            input_int[current_position]++;
                        }
                        

                        current_position += how_many_steps;

                        if ((current_position < 0) || (current_position >= input_int.Length))
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(total_number_of_steps);
                    break;
                }
        }
    }
}
