using System;

namespace Tärningsspel__Nackademin_
{
    class Program
    {
        public static int totalsum { get; set; }
        public static int count { get; set; }
        static void Main(string[] args)
        {
             Game();
            Primtal();
        }
        public static void Game()
        {
            Console.WriteLine("Ett tärningsspel, varje gång du det blir en sexa, två nya tärningar slås");
            Console.WriteLine("Summan läggs inte till vid sexor");
            Console.WriteLine("skriv ut den totala summan hittils och antal tärningskast");
            Console.WriteLine("felhantering");
            Console.WriteLine("");
            Console.WriteLine("Välj antal tärningar du vill ska kastas (1-5)");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int exDice1 = 0;
            int exDice2 = 0;
            Random rnd = new Random();

            for (int i = 0; i < choice; i++)
            {
                int Number = 6;
                //int Number = rnd.Next(1, 7);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(i + 1 + ". " + Number);
                Console.ResetColor();

                if (Number == 6)
                {
                    int Amount6 = 1;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det blev en sexa, 2 nya tärningar slås");

                    do
                    {
                        exDice1 = rnd.Next(1, 7);

                        if (exDice1 == 6)
                        {
                            Amount6++;
                        }

                        if (exDice1 != 6)
                        {
                            totalsum += exDice1;
                        }
                        exDice2 = rnd.Next(1, 7);

                        if (exDice2 == 6)
                        {
                            Amount6++;
                        }

                        if (exDice2 != 6)
                        {
                            totalsum += exDice2;
                        }
                        count += 2;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(exDice1);
                        Console.WriteLine(exDice2);
                        Console.WriteLine("");
                        Console.ResetColor();

                        Amount6--;
                    } while (Amount6 != 0);
                }

                if (Number != 6)
                {
                    totalsum += Number;
                }
                count++;
            }

            Linedivide();
            Console.WriteLine("Antal tärningskast " + count);
            Console.WriteLine("Total summan: " + totalsum);
            Console.WriteLine("Vill du köra igen?");
            Console.WriteLine("");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "JA")
            {
                Console.Clear();
                Game();
            }
        }
        private static void Linedivide()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public static void Primtal()
        {
            for (int i = 2; i <= 20; i++)
            {
                int count = 0;
                if (i != 2)
                {
                    for (int c = 2; c < i; c++)
                    {
                        if (i % c == 0)
                        {
                            count++;
                        }
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
