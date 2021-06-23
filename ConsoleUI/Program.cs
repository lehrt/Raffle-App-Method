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
        private static Random _rdm = new Random();
        private static Random randomNumber = new Random();

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
            List<string> names = new List<string> { };

            do
            {
                name = GetUserInput("Please enter your name.");
                otherGuest = (GetUserInput("Do you want to add any other names? Please input 'yes' or 'no.'").ToLower());
                names.Add(name);
            }
            while (otherGuest == "yes");


            foreach (string nameName in names)
            {
                Console.WriteLine(nameName);
            }
        }

     
        public static int RandomNumber(int min = 1000, int max = 9999)
        {
            return randomNumber.Next(min, max);
        }
        static void Main(string[] args)
        {

            Console.WriteLine(RandomNumber());


        }

        //Start writing your code here


        //I need this code to recycle the questions
        // but it's only asking once, and then it keeps printing the asnwers input the first time.
        //



/*        static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
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
        }*/
    }
}
