using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                switch (i)
                {
                    case 0:
                        for(int j = 0; j <= 10; j++)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 1:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 2; j <= 20; j = j + 2)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 3; j <= 30; j = j + 3)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 4; j <= 40; j = j + 4)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 5; j <= 50; j = j + 5)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 6; j <= 60; j = j + 6)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 7; j <= 70; j = j + 7)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 8; j <= 80; j = j + 8)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 9:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 9; j <= 90; j = j + 9)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                    case 10:
                        Console.Write(format: "{0}\t", arg0: i);
                        for (int j = 10; j <= 100; j = j + 10)
                        {
                            Console.Write(format: "{0}\t", arg0: j);
                        }
                        Console.WriteLine();
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
