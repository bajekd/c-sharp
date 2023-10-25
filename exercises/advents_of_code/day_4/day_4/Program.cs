using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_day_4
{   /* String.Concat(str.OrderBy(c => c))
    DO WYKORZYSTANIA W WERSJI Z UŻYCIEM DICTIONARY!!!
     W razie czego zapytaj <Ateusza jak zrobił zadanie z day_4 */
    class Program
    {
        static void Main( string[] args )
        {
            string path_to_file = @"C:\Users\Blaise\source\repos\Advent_of_code_day_4\file.txt";
            string[] input = File.ReadAllLines( path_to_file );

            how_many_passwords_are_valid( input );
   
            Console.ReadKey();
        }

        static void how_many_passwords_are_valid( string[] input )
        {
            int how_many_passwords_are_valid = 0;
            bool is_this_line_valid = true;
            
            foreach( string line in input )
            {
                string[] one_line = line.Split(' ');
                
                for(int i = 0; i < one_line.Length; i++)
                {
                    is_this_line_valid = true;
                    for ( int j = i + 1; j < one_line.Length; j++ )
                    {
                        if ( one_line[i] == one_line[j] )
                        {
                            is_this_line_valid = false;
                            break;
                        }
                        
                        //chceck if strings are anagram - part_2 - BEGIN
                        if (one_line[i].Length == one_line[j].Length)
                        {
                            string word_1 = one_line[i];
                            string word_2 = one_line[j];

                            foreach( char c in word_2 )
                            {
                                int index = word_1.IndexOf(c);
                                if (index >= 0)
                                {
                                    word_1 = word_1.Remove(index, 1);
                                }
                                else
                                {
                                    break;
                                }
                            } 

                            if ( String.IsNullOrEmpty(word_1) )
                            {
                                is_this_line_valid = false;
                                break;
                            }
                        }
                        //check if strings are anagram - part_2 -  END
                    }

                    if(is_this_line_valid == false)
                    {
                        break;
                    }
                }

                if(is_this_line_valid == true)
                {
                    how_many_passwords_are_valid += 1;
                }
            }

            Console.WriteLine(how_many_passwords_are_valid);
        }    
    }
}
