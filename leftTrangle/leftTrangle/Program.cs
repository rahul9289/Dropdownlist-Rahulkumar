using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftTrangle
{
    public class rectangle

    {
        // int row = 5;
        //int j = 3;
        string name = "pattern";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row number");
            string name = Console.ReadLine();

            int pattern = Convert.ToInt32(name);





            switch (pattern)
            {
                case 1:
                    pattern1 ();

                    break;

            };
   

         








            


        }

       static void pattern2()
        {
            Console.WriteLine("Enter the row number");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
        static void pattern1()
        {
            for (int i = 1; i <= 5; i++) // Number of rows
            {
                // Print spaces before the stars (for left alignment)
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");

                }
                // Print stars
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();

            }
        }

        static void pattern3()
        {
            Console.WriteLine("Enter row number");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 5; i++) // Number of rows
            {
                // Print spaces before the stars (for left alignment)
                for (int j = 1; j <= 5 - i; j++)              // for (int j= 5; j>row; j--)
                {
                    Console.Write(" ");

                }
                // Print stars
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }

        static void pattern4()
        {
            int row = 6;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (j == 1 || i == row - 1) // Condition for the left and bottom edge
                    {
                        Console.Write("* "); // Print the star
                    }
                    else
                    {
                        Console.Write("  "); // Print spaces otherwise
                    }
                }
                Console.WriteLine(); // Move to the next line
            }
        }
    }
}








