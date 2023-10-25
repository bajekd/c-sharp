using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Używane zmienne globalne
            int min = 0, max = 1, tempolary_variable, number_of_draws;
            int[] rand_numbers = new int[2];
            while (true)
            {

                
                
                try 
                {
                    // liczba zestawów do losowania z obsługą wyjątków & przygotowanie generatora liczb
                    Console.WriteLine("Podaj liczbę zestawów do wylosowania: ");
                    number_of_draws = Convert.ToInt32(Console.ReadLine());

                    if (number_of_draws <= 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {

                    Console.WriteLine("Liczba zestawów do wylosowania musi być nieujemna!");

                }
                catch (FormatException)
                {

                    Console.WriteLine("Podana wartość nie jest liczbą!");

                }
            }
            Random rnd = new Random();

            // Wygenerowanie x tablic po 6 (losowych) elementów każda
            for (int x = 1; x <= number_of_draws; x++) { 

                //Wygenerowanie liczb losowych (bez powtórzeń) w tablicy
                for (int i = 0; i < rand_numbers.Length; i++) {

                    rand_numbers[i] = rnd.Next(min, max);
                    for (int j =  0; j < i; j++) { // eliminacja potencjalnych powtórzeń

                        if (rand_numbers[i] == rand_numbers[j]) {

                            rand_numbers[i] = rnd.Next(min, max);
                            j = -1;
                            
                        }
                        Console.WriteLine("Duplikat,  i = {0}, j = {1}, rand_number = {2}", i,j,rand_numbers[i]);
                    }
                }

                //Sortowanie bąbelkowe:
                for (int i = 0; i < rand_numbers.Length - 1; i++) {

                    for (int j = 0; j < rand_numbers.Length - 1; j++) {

                        if (rand_numbers[j] > rand_numbers[j + 1]) {

                            tempolary_variable = rand_numbers[j];
                            rand_numbers[j] = rand_numbers[j + 1];
                            rand_numbers[j + 1] = tempolary_variable;
                        }
                    }
                }

                //Wyświetlenie (posortowanej) tablicy
                Console.WriteLine();
                Console.WriteLine("Oto twoja (posortowana) tablica_{0}: ", x);
                for (int i = 0; i < rand_numbers.Length; i++) {

                    Console.Write("{0} \t", rand_numbers[i]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
            
        }
    }
