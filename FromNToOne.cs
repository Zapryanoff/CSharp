using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = n; i >= 1; i--) { 
            
                System.Console.WriteLine(i);
            }
        }
    }
}