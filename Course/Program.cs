using System;

public class Program
{
    public static void Main()
    {
        Course course = new Course();
        bool Exit = false;

        while (!Exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Remove student");
            Console.WriteLine("3. Display all students");
            Console.WriteLine("4. Search student");
            Console.WriteLine("5. Count all students");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter surname: ");
                    string surname = Console.ReadLine();
                    Console.Write("Enter age: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.Write("Enter student PIN: ");
                        string pin = Console.ReadLine();
                        Student student = new Student(name, surname, age, pin);
                        course.AddStudent(student);
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Try again.");
                    }
                    break;

                case "2":
                    Console.Write("Enter PIN to remove: ");
                    string pinToRemove = Console.ReadLine();
                    course.RemoveStudent(pinToRemove);
                    break;

                case "3":
                    course.DisplayAllStudents();
                    break;

                case "4":
                    Console.Write("Enter PIN to search: ");
                    string pinToSearch = Console.ReadLine();
                    course.SearchStudent(pinToSearch);
                    break;

                case "5":
                    Console.Write("Enter minimum age of students: ");
                    if (int.TryParse(Console.ReadLine(), out int minAge))
                    {
                        int count = course.StudentAge(minAge);
                        Console.WriteLine($"All students above {minAge} years old: {count}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Try again.");
                    }
                    break;

                case "6":
                    Exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
