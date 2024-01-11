using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        // Input data for students
        Console.WriteLine("Enter names and heights of students:");

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Name of student {0}: ", i + 1);
            string name = Console.ReadLine();

            Console.Write("Height of student {0} (in centimeters): ", i + 1);
            double height = double.Parse(Console.ReadLine());

            students.Add(new Student(name, height));
        }

        // Display the list of data
        Console.WriteLine("\nList of student data:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Height: {student.Height} cm");
        }

        // Find the tallest student
        Student tallestStudent = FindTallestStudent(students);
        Console.WriteLine($"\nThe tallest student is: {tallestStudent.Name} with a height of {tallestStudent.Height} cm");

        // Calculate the average height of students
        double averageHeight = CalculateAverageHeight(students);
        Console.WriteLine($"Average height of students: {averageHeight} cm");

        // Add your data
        Console.Write("\nEnter your name: ");
        string myName = Console.ReadLine();

        Console.Write("Enter your height (in centimeters): ");
        double myHeight = double.Parse(Console.ReadLine());

        students.Add(new Student(myName, myHeight));

        // Display the updated list of data
        Console.WriteLine("\nUpdated list of student data:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Height: {student.Height} cm");
        }
    }

    // Method to find the tallest student
    static Student FindTallestStudent(List<Student> students)
    {
        Student tallestStudent = students[0];

        foreach (var student in students)
        {
            if (student.Height > tallestStudent.Height)
            {
                tallestStudent = student;
            }
        }

        return tallestStudent;
    }

