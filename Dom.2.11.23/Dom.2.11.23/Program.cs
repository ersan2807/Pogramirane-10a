using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[2, 2];

        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Matrix[{i},{j}] = ");
                if (int.TryParse(Console.ReadLine(), out matrix[i, j]) == false)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    j--;
                }
            }
        }
        int sumRow1 = matrix[0, 0] + matrix[0, 1];
        int sumRow2 = matrix[1, 0] + matrix[1, 1];
        Console.WriteLine("Sum of the first row: " + sumRow1);
        Console.WriteLine("Sum of the second row: " + sumRow2);
    }
}
