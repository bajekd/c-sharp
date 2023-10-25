using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbę wierszy : ");
            string liczba_wierszy_str = Console.ReadLine();

            Console.WriteLine("Wpisz liczbę kolumn : ");
            string liczba_kolumn_str = Console.ReadLine();

            Console.WriteLine();
            int liczba_wierszy = Convert.ToInt32(liczba_wierszy_str);
            int liczba_kolumn = Convert.ToInt32(liczba_kolumn_str);

            for(int i = 1; i <= liczba_wierszy; i++)
            {
                //Console.Write("*");

                for(int j = 1; j <= liczba_kolumn; j++)
                {
                    Console.Write("*\t");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
