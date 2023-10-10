using System;

class Program
{
    static void Main()
    {
        // Enter your birthdate (DD/MM/YYYY):
        Console.Write("Enter your birthdate (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        DateTime today = DateTime.Now;

        TimeSpan difference = today - birthDate;

        ulong millisecondsPassed = (ulong)difference.TotalMilliseconds;

        ulong daysPassed = millisecondsPassed / (ulong)(1000 * 60 * 60 * 24);

        Console.WriteLine("The number of days passed from your birthdate to today is: " + daysPassed);
    }
}

    }
}
