using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_Largest_Element_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minSizeMatrix = 1;
            int maxSizeMatrix = 10;
            int maxElementMatrix = 0;
            int numberRow = random.Next(minSizeMatrix, maxSizeMatrix);
            int numberColumn = random.Next(minSizeMatrix, maxSizeMatrix);
            int[,] array = new int [numberRow, numberColumn];

            Console.WriteLine("Исходная матрица: \n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next();
                    if (maxElementMatrix < array[i, j])
                    {
                        maxElementMatrix = array[i, j];
                    }
                    Console.Write(array[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine($"\nМаксимальный элемент в матрице {maxElementMatrix}\n");

            Console.WriteLine("Изменённая матрица: \n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == maxElementMatrix)
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
