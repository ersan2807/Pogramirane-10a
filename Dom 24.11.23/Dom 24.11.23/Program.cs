using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns (m): ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        Console.WriteLine("Enter the elements of the matrix:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The matrix is:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("First row of the matrix:");

        for (int j = 0; j < m; j++)
        {
            Console.Write(matrix[0, j] + " ");
        }

        Console.WriteLine();

        // Convert the matrix to a one-dimensional array
        int[] flattenedArray = new int[n * m];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                flattenedArray[index++] = matrix[i, j];
            }
        }

        // Sort the one-dimensional array
        Array.Sort(flattenedArray);

        // Display the sorted array
        Console.WriteLine("Sorted numbers in the matrix:");

        for (int i = 0; i < flattenedArray.Length; i++)
        {
            Console.Write(flattenedArray[i] + " ");
        }

        Console.WriteLine();
    }
}
