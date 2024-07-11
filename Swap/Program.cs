using System;

public class Program
{
    public static void SwapAndPrint<T>(ref T first, ref T second)
    {
        T temp = first;
        first = second;
        second = temp;

        Console.WriteLine($"First: {first}, second: {second}");
    }

    public static void Main()
    {
        int a = 10;
        int b = 20;
        Console.WriteLine("Before swap:");
        Console.WriteLine($"a: {a}, b: {b}");
        SwapAndPrint(ref a, ref b);
        Console.WriteLine("After swapping:");
        Console.WriteLine($"a: {a}, b: {b}");

        string word1 = "Hello";
        string word2 = "World";
        Console.WriteLine("Before swap:");
        Console.WriteLine($"Word1: {word1}, word2: {word2}");
        SwapAndPrint(ref word1, ref word2);
        Console.WriteLine("After swapping:");
        Console.WriteLine($"first word: {word1}, second word: {word2}");
    }
}
