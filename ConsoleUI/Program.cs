using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static Dictionary<int, string> guests = new Dictionary<int, string>();
        public static int min = 1000;
        public static int max = 9999;
        private static int raffleNumber;
        private static Random randomNumber = new Random();
        private static Random winner = new Random();


        static string GetUserInput(string question)
        {
            Console.WriteLine(question);
            string input = Console.ReadLine();
            
            return input;
        }


        static void GetUserInfo()
        {
            string name;
            string otherGuest;

            do
            {
                name = GetUserInput("Please enter your name.");
                otherGuest = (GetUserInput("Do you want to add any other names? Please input 'yes' if so.").ToLower());
                raffleNumber = RandomNumber();
                guests.Add(raffleNumber, name);
            }
            while (otherGuest == "yes");
            
/*            MultiLineAnimation();*/
            
            foreach (var numAndName in guests)
            {
                Console.WriteLine($"{numAndName.Key} : {numAndName.Value}");
            }            
        }

        static int RandomNumber(int min = 1000, int max = 9999)
        {
            return randomNumber.Next(min, max);
        }

        static void PrintGuestsName()
        {
            Console.WriteLine("Press any key when you're ready to know the winner!");
            Console.ReadKey();
            MultiLineAnimation();

            foreach (var numAndName in guests)
            {
                Console.WriteLine($"{numAndName.Key} : {numAndName.Value}");
            }
        }

        static void PrintWinner()
        {
            int index = winner.Next(guests.Count);
            KeyValuePair<int, string> pair = guests.ElementAt(index);
            Console.WriteLine($"The Winner is: {pair.Key} with {pair.Value}!! Congrats!");
        }




        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to the Party!!");
                GetUserInfo();
                PrintGuestsName();
                PrintWinner();

            }
        }



        static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
        {
            var counter = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();

                switch (counter % 4)
                {
                    case 0:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    │││ \\   ║");
                            Console.WriteLine("         ║    │││  O  ║");
                            Console.WriteLine("         ║    OOO     ║");
                            break;
                        };
                    case 1:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║   / │││    ║");
                            Console.WriteLine("         ║  O  │││    ║");
                            Console.WriteLine("         ║     OOO    ║");
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                }

                counter++;
                Thread.Sleep(200);
            }
        }
    }
}





//how to return max w/in an array
/*        static int GetRaffleNumber(Dictionary<int, string> dict)
        {
            dict = guests;
            int maxKey = guests.Keys.Max();
            return maxKey;
        }*/