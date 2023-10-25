using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj stopień macierzy kwadratowej: ");
            string stopień_macierzy_str = Console.ReadLine();

            int stopień_macierzy= Convert.ToInt32(stopień_macierzy_str);
            Console.WriteLine();

            for(int i = 1; i <= stopień_macierzy; i++) //Rysunek pierwszego trójkąta 
            {
                for(int j = i; j <= stopień_macierzy; j++) //W pierwszym rzędzie liczba gwiazdek = st_macierzy, w każdym kolejnym zmniejsza się ona o jeden. Zaczyna się od j =1 i dopełnia do m, potem jest j =2 , j = 3, j = 4 etc...
                {
                    Console.Write("*\t");
                }
                Console.WriteLine(); //spacje pomiędzy rzędami w macierzy
            }

            Console.WriteLine(); // Odstęp między pierwszym, a drugim trójkątem (można zrobić to samo używając "powrotu karetki" ("\n")

            for (int i = 1; i <= stopień_macierzy; i++)// Rysunek drugiego trójkąta. 
            {
                for(int j = 1; j <= i; j++)// W pierwszym rzędzie liczba gwiazdek = 1, w każdym kolejnym inkrementuje się o 1 (aż do wartości = st_macierzy). J zawsze zaczyna się od 1 i zmierza do wartości i (więc w 3 iteracji pętli zewnętrznej i =3, a więcta wewnętrzna pętla powtórzy się trzy razy (startując od j = 1, aż do j <= 3 (i) w tym wypadku 
                {
                    Console.Write("*\t");
                }
                Console.WriteLine(); //spacje pomiędzy rzędami w macierzy
            }

            Console.WriteLine(); // Odstęp między drugim, a trzecim trójkątem

            for (int i = 1; i <= stopień_macierzy; i++)// Rysunek trzeciego trójkąta 
            {
                for (int j = 1; j <= stopień_macierzy; j++) // Tutaj w każdym rzędzie mamy liczbę znaków = st_macierzy (przy czym raz się to tabulatory, a raz gwiazdki z tabulatorami). W pierwszym rzędzie mamy same gwiazdki, w drugim tabulator = 1 i gwiazdki = st_macierzy-1,w każdym kolejnym o 1 inkrementujemy o  l liczbę tabulatorów i jednocześnie dekrementujemy o 1 liczbę gwiazdek
                {
                    if (j < i)
                    {
                        Console.Write("\t");// dzięki takiemu przedstawieniu - dla np. i = 3, w pierwszym i drugim obiegu wewnętrznej pętli (dla j = 1 oraz dla j = 2) zrobi tabulatory, a od j = 3, aż do j = st_macierzy będzie dawało sameg gwiazdki
                    }
                    else
                    {
                        Console.Write("*\t");
                    }
                }
                Console.WriteLine(); //spacje pomiędzy rzędami w macierzy
            }

            Console.WriteLine(); // Odstęp między trzecim, a czwartym trójkątem

            for (int i = 1; i <= stopień_macierzy; i++)// Rysunek czwartego trójkąta
            {
                for (int j = stopień_macierzy; j >= 1; j--) // Trzeci trójkąt z odwróconą kolenością gwiazdek - tutaj rownież w każdym rzędzie mamy tyle samo znaków ( = st_macierzy), przy czym raz są to tabulatory, a raz gwiazdki. W trzecim trójkącie zaczynaliśmy od samych gwiazdek w pierwszym rzędzie, tutaj zaczynamy od jedenj gwiazdki i reszty tabulatorów w pierwszym rzędzie, a następnie zmniejszamy liczbę tabulatorów, przy jednoczesnym zwięlkszeniu liczby gwiazdek.
                {
                    if(i < j)
                    {
                        Console.Write("\t");// analogicznie jak w trzecim trójkącie, przy czym tutaj dopiero ostatni obiek wewnętrznej pętli -> j = st_macierzy, nie spełni tego warunku i przejdzie do elsa
                    }
                    else
                    {
                        Console.Write("*\t");
                    }
                }
                Console.WriteLine();// //spacje pomiędzy rzędami w macierzy
            }

            Console.ReadKey();
        }
    }
}
