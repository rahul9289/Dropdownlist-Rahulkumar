using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = row
            //int n = 8;
            int row = 6;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j<= row; j++)
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

