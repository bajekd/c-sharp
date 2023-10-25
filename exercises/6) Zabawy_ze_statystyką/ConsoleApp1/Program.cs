using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length_of_array, minimum_from_array, maximum_from_array, max_value_for_searching_mode, sum = 0, temporary_variable_for_bubble_sort, how_many_repeats_searching_mode = 0, temporary_variable_for_searching_mode;
            double arytmetic_mean, median;
            int[] tablica;

            Console.WriteLine("Podaj liczbę elementów: "); //obsługa wyjątków - int =< 0 oraz =! int
            length_of_array = Convert.ToInt32(Console.ReadLine()); //Console.Readline() zwraca stringa, nas interesuje int

            tablica = new int[length_of_array];
            Random rnd = new Random();

            // uzupełnienie tablicy liczbami losowymi (możliwe powtórzenia)
            for (int i = 0; i < tablica.Length; i++)
            {

                tablica[i] = rnd.Next(1, 7); //losuje liczbę z zakresu(namniejsza, największa - 1)
            }

            //znajdowanie minimum
            minimum_from_array = tablica[0];
            for (int i = 1; i < tablica.Length; i++)
            {

                if (tablica[i] < minimum_from_array)
                {

                    minimum_from_array = tablica[i];
                }
            }

            //znajdowanie maksimum
            maximum_from_array = tablica[0];
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] > maximum_from_array)
                {

                    maximum_from_array = tablica[i];
                }
            }

            //średnia arytmetyczna
            for(int i = 0; i < tablica.Length; i++)
            {
                sum = tablica[i] + sum;
            }

            arytmetic_mean = (double)sum / (double)tablica.Length;

            //mediana 
            for (int i = 0; i < tablica.Length - 1; i++) // uporządkowanie ciągu (sortowanie bąbelkowe rosnące)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        temporary_variable_for_bubble_sort = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temporary_variable_for_bubble_sort;
                    }
                }
            }

            if (tablica.Length % 2 == 0) // dla parzystej liczby elementów 
            {
                median = ( ( (double)tablica[(tablica.Length / 2) - 1] + (double)tablica[tablica.Length / 2] ) / 2 ); // dostosowanie do numeracji tablicy (3 element ciągu ma 2 indeks w tablicy - numerujemy od 0)
            } 
            else //dla nieparzystej liczby elementów
            {
                median = (double)tablica[ (tablica.Length / 2) + 1];
            }

            //dominanta
            int[,] tablica_dominanta = new int [2, length_of_array]; // zadeklarowanie dwuwymiarowej tablicy
            for ( int i = 0; i < tablica.Length; i++) // przepisanie do nowej tablicy pierwszego wiersza ze starej tablicy - losowych liczb
            {
                tablica_dominanta[0, i] = tablica[i];
            }

            for (int i = 0; i < tablica.Length; i++) // uzupełnienie drugiego wiersza tablicy - ile razy dana liczba (z 1-szego rzędu) się powtarza
            {
                temporary_variable_for_searching_mode = tablica_dominanta[0, i];

                for (int j = 0; j < tablica.Length; j++)
                {
                    if (tablica_dominanta[0, j] == temporary_variable_for_searching_mode)
                    {
                        how_many_repeats_searching_mode++;
                    }
                }
                tablica_dominanta[1, i] = how_many_repeats_searching_mode;
                how_many_repeats_searching_mode = 0;

            }
            max_value_for_searching_mode = tablica_dominanta[1, 0];
            for(int i = 0; i < tablica.Length; i++) //szukanie maksimum z drugiego wiersza tablicy
            {
                if (tablica_dominanta[1, i] > max_value_for_searching_mode )
                {
                    max_value_for_searching_mode = tablica_dominanta[1, i];
                }
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            //Wyświetlanie wyników
            foreach (int i in tablica)
            {
                Console.Write("{0} \t", i);
            }
            Console.WriteLine();
            Console.WriteLine("Minimum dla zadanego zakresu = {0}", minimum_from_array);
            Console.WriteLine("Maksimum dla zadanego zakresu = {0}", maximum_from_array);
            Console.WriteLine("Średnia arytmetyczna dla zadanego zakresu = {0}", arytmetic_mean);
            Console.WriteLine("Mediana dla zadengo zakresu = {0}", median);
            Console.WriteLine("Dominatna dla zadnanego zakresu = {0}" );

            Console.ReadKey();
        }
    }
}
