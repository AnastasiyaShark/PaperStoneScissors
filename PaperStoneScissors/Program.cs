using System;

namespace PaperStoneScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool ending= true;

            String[] items = new String[3];
            items[0] = "Stone";
            items[1] = "Scissors";
            items[2] = "Paper";

            int coincidental = random.Next(items.Length);
            string coincidental2 = items[coincidental];

            while (ending) {
                foreach (var item in items)
                {
                    Console.WriteLine((Array.IndexOf(items, item) + 1) + " " + item.ToString());
                }
                Console.Write("Your choice is ? — ");

                try
                {
                    int Choice = int.Parse(Console.ReadLine());

                    if (Choice <1 || Choice > 3)
                    {
                        Console.WriteLine("Invalid count. Try again!");
                        continue;
                    }
             
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Stone vs {0}", coincidental2);

                        if (coincidental2 != items[0] && coincidental2 != items[2])
                            Console.WriteLine("You Win :)");


                        else if (coincidental2 != items[0] && coincidental2 != items[1])
                            Console.WriteLine("You Lose :( ");

                        else
                            Console.WriteLine("You Draw");
                        ending = GameOver();

                        break;
                    case 2:
                        Console.WriteLine("Scissors vs {0}", coincidental2);

                        if (coincidental2 != items[1] && coincidental2 != items[0])
                            Console.WriteLine("You Win :)");
                        else if (coincidental2 != items[1] && coincidental2 != items[2])
                            Console.WriteLine("You Lose :( ");
                        else
                            Console.WriteLine("You Draw");
                        ending = GameOver();
                        break;
                    case 3:
                        Console.WriteLine("Paper vs {0}", coincidental2);
                        if (coincidental2 != items[2] && coincidental2 != items[1])
                            Console.WriteLine("You Win :) ");
                        else if (coincidental2 != items[2] && coincidental2 != items[0])
                            Console.WriteLine("You Lose :( ");
                        else
                            Console.WriteLine("Draw!");
                        ending = GameOver();
                        break;
                }

                Console.ReadKey();
            }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid data format. Try again!");
                    continue;
                    throw new FormatException("Invalid data format. Try again!", ex);

                }
            }
            Console.WriteLine("Game Over!");

        }


        static bool GameOver()
        {
        Console.WriteLine("To continue the game press twice Enter\r\nTo exit the game enter end");
        string endOrNot = Console.ReadLine();
        return (endOrNot != "end" ? true : false);
        }
    }
}
