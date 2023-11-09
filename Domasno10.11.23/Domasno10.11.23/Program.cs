using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns (m): ");
        int m = int.Parse(Console.ReadLine());
        int[,] array = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Even numbers in row {i}: ");
            for (int j = 0; j < m; j++)
            {
                if (array[i, j] % 2 == 0)
                {
                    Console.Write($"{array[i, j]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
