using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_kolokwium_zaoczni
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ZAD_3
             */
            
            /*ZAD_4
            1) Wygeneruj tablicę liczb od 1 - 300.
            2) Które liczby są podzielne przez ( (2 && 3) || 5 )
            3) Wyświetl wyniki */

            Console.WriteLine("Zadanie 4\n");
            int[] tablica = create_array();
            which_number_are_evenly_divided(tablica);

            Console.ReadKey();
        }
        //ZAD_3

        //ZAD_4
        static int[] create_array()
        {
            int[] array = new int[300];
            int number = 1;

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = number;
                number++;
            }
            return array;
        }

        static void which_number_are_evenly_divided(int[] input)
        {
            foreach(int element in input)
            {
                if( (element % 2 == 0 && element % 3 == 0) || (element % 5 == 0) )
                {
                    Console.WriteLine(element);
                }
            }
            
        }

    }
}
