using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Fatime", "Elcan", "Xanim", "Emilya", "Amine" };
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Length > 5)
                {
                    Console.WriteLine(students[i]);
                }
            }
        }
    }
}
        
    

