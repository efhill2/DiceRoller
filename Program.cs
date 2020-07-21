using System;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace DiceRoller
{
    class Program
    {

        public static void GetRandomNumbers(ref int Random1, ref int Random2)
        {
            Random rand = new Random();

            //Console.WriteLine("How many sides does the dice have?");

            //int diceSide = Convert.ToInt32(Console.ReadLine());

            //int x ; 
            //int y ;

            Random1 = rand.Next(1, Random1 + 1);
            Random2 = rand.Next(1, Random2 + 1);

            //for (int i = 1; i < diceSide; i++)
            //{
            //   x = rand.Next(i);
            //}
            //for (int j = 1; j < diceSide; j++)
            //{
            //   y = rand.Next(j);
            //}

            Console.WriteLine($"Roll : {Random1}, {Random2}");


        }

        public static void GetDiceCombos(int diceSide, int x, int y)
        {
            int total = x + y;
            
            if (diceSide == 6)
            {
                if ((x == 1) && (y == 1))
                {
                    Console.WriteLine("Snake Eyes");
                }
                else if ((x == 1 || y == 1) && (x == 2 || y == 2))
                {
                    Console.WriteLine("Ace Deuce");
                }
                else if (x == 6 && y == 6)
                {
                    Console.WriteLine("Box Cars");
                }
                else if ((total == 7) || (total == 11))
                {
                    Console.WriteLine("Win");
                }
                else if ((total == 2) && (total == 3) && (total == 12))
                {

                }
            }
            else if (diceSide != 6)
            {

            }
        }

        static void Main(string[] args)
        {
            string ans;
            int diceSide;
            int x;
            int y;
           

            do
            {
                Console.WriteLine("Would you like to roll the dice?");

                Console.WriteLine("");
                ans = Console.ReadLine().ToLower();

                if (ans == "n")
                {
                    Console.WriteLine("Goodbye");
                }
                else if (ans == "y")
                {
                    Console.WriteLine("How many sides does the dice have?");

                    diceSide = Convert.ToInt32(Console.ReadLine());
                                        
                    x = diceSide;
                    y = diceSide;



                    GetRandomNumbers(ref x, ref y);
                    GetDiceCombos(diceSide, x, y);
                    
                }

            } while (ans != "n");
            

        }

       
    }
}
