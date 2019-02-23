/*
 * C# Program to Get 2 Arrays as Input and Produce a 3rd Array by Appending one to 
 * other
 */
using System;
//first comment
//second comment
class Program
{
    static void Main()
    {
        int[] array1 = new int[5];
        int[] array2 = new int[5];
        int[] array3 = new int[array1.Length + array2.Length];
        Console.WriteLine("Enter Any 5 Elements for the First Array :");
        for (int i = 0; i < 5; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter Any 5 Elements for the Second Array :");
        for (int i = 0; i < 5; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }
        Buffer.BlockCopy(array1, 0, array3, 0, array1.Length * sizeof(int));
        Buffer.BlockCopy(array2, 0, array3, array1.Length * sizeof(int), array2.Length * sizeof(int));
        Console.WriteLine("Elements in the Third Array After Appending First and Second Arrays :");
        foreach (int value in array3)
        {
            Console.WriteLine(value);
        }
        Console.ReadLine();
    }
}