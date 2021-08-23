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

           

            while (ending) {

                int coincidental = random.Next(items.Length);
                string coincidental2 = items[coincidental];

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
                    Console.WriteLine("Your choice:" + items.GetValue(Choice - 1));
                    Console.WriteLine("Computer choice:" + coincidental2);
                    

                    if ((coincidental+1) == Choice)
                    {
                        Console.WriteLine("You Draw");
                        ending = GameOver();
                        continue;
                    }
                    int newc = coincidental + 1;
                    int min = Choice - newc;
                    Console.WriteLine(min);
                    if ( min == -1 || min == 2)
                    {
                        Console.WriteLine("You Win :)");
                        ending = GameOver();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You Lose :( ");
                        ending = GameOver();
                        continue;
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
