using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //używane zmienne
            double numbers_to_chceck;
            bool is_prime;

            //wybór zakresu && wyświetlanie tekstu
            Console.WriteLine("Wpisz zakres liczb do sprawdzenia - od 1 do : ");
            numbers_to_chceck = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("W zakresie od 1 do {0} znajdują się następujące liczby pierwsze: ", arg0: numbers_to_chceck);

            //wielki test na bycie liczbą pierwszą
            for (int i = 2; i <= numbers_to_chceck; i++) {

                is_prime = true;

                if(i == 2) { // przypadek podstawowy - najmniejsza liczba pierwsza
                    Console.WriteLine(i);
                }
                else {

                    for (int j = 2; j <= Math.Sqrt(numbers_to_chceck); j++) {

                        if (i % j == 0) {
                            is_prime = false;
                            break;
                        }
                    }

                    if (is_prime) {
                            Console.WriteLine(i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
