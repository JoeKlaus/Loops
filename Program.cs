using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            do
            {
                PrintMenu();
                userChoice = int.Parse(Console.ReadLine());
                

                if (userChoice == 1)
                {
                    CountTo100();
                }
                else if(userChoice == 2)
                {
                    CountDownFrom100();
                }
                else if (userChoice == 3)
                {
                    CountByTwos();
                }
            } while (userChoice != 4);
        } // end main
        static void CountTo100()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void CountDownFrom100()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void CountByTwos()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("1. Count To 100");
            Console.WriteLine("2. Count Down From 100");
            Console.WriteLine("3. Count to 100 by 2's");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Select one: ");
        }
    }
}
