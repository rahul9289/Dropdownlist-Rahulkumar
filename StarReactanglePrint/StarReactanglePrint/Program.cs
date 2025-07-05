using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace StarReactanglePrint
{
   internal class Program
    {

        int row = 6;
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the row number");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <=row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }

       
    } 




 /*public class rectangle

    {
      

        static void Main(string[] args)
        {
            Console.WriteLine("Enter row number");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=5; i++) // Number of rows
            {
                // Print spaces before the stars (for left alignment)
                for (int j = 1; j <=5 - i; j++)              // for (int j= 5; j>row; j--)
                {
                    Console.Write(" ");

                }
                // Print stars
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }

    } */


    
} 


   