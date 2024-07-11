using System;
using System.Collections.Generic;
using System.Linq;

public class Course
{
    private List<Student> students;

    public Course()
    {
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        if (!students.Exists(Student => Student.PIN == student.PIN))
        {
            students.Add(student);
            Console.WriteLine($"Student {student.Name} added.");
        }
        else
        {
            Console.WriteLine($"student with PIN '{student.PIN}' already exists.");
        }
    }

    public void RemoveStudent(string pin)
    {
        Student student = students.FirstOrDefault(Student => Student.PIN == pin);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine($"Student {student.Name} removed.");
        }
        else
        {
            Console.WriteLine($"Student '{pin}' not found.");
        }
    }

    public void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students in the course.");
            return;
        }

        Console.WriteLine("All students in the course:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    public void SearchStudent(string pin)
    {
        Student student = students.FirstOrDefault(Student => Student.PIN == pin);
        if (student != null)
        {
            Console.WriteLine($"Student found: {student}");
        }
        else
        {
            Console.WriteLine($"Student '{pin}' not found.");
        }
    }

    public int StudentAge(int age)
    {
        return students.Count(Student => Student.Age > age);
    }
}
