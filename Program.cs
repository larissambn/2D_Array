using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1
            // Create a 2D char array with 6 rows and 10 columns.
            char[,] xArray = new char[6, 10];

            // loop trought the rows
            for (int row = 0; row < xArray.GetLength(0); row++)
            {
                // loop trought the columns
                for (int column = 0; column < xArray.GetLength(1); column++)
                {
                    // Initialize the array with the character 'X'.
                    xArray[row, column] = 'X';
                }
            }

            // Print the array.
            for (int row = 0; row < xArray.GetLength(0); row++)
            {
                for (int column = 0; column < xArray.GetLength(1); column++)
                {
                    Console.Write(xArray[row, column]);
                }
                Console.WriteLine();
            }

            // Task 2
            // Change the following elements to print letter "O".
            xArray[0, 3] = 'O';
            xArray[0, 1] = 'O';
            xArray[3, 5] = 'O';
            xArray[2, 4] = 'O';
            xArray[1, 1] = 'O';

            // Print the array.
            for (int row = 0; row < xArray.GetLength(0); row++)
            {
                for (int column = 0; column < xArray.GetLength(1); column++)
                {
                    Console.Write(xArray[row, column]);
                }
                Console.WriteLine();
            }

            // Task 3
            // Change the 'O' elements to 'Z' 
            for (int row = 0; row < xArray.GetLength(0); row++)
            {
                for (int column = 0; column < xArray.GetLength(1); column++)
                {
                    if (xArray[row, column] == 'O')
                        xArray[row, column] = 'Z';

                    Console.Write(xArray[row, column]);

                }
                Console.WriteLine();
            }

            // Task 4 
            // Change all the elements in the last row to "S"
            for (int row = 0; row < xArray.GetLength(0); row++)
            {
                for (int column = 0; column < xArray.GetLength(1); column++)
                {
                    if (row == 5) xArray[row, column] = 'S';
   
                    Console.Write(xArray[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}