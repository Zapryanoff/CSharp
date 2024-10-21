using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double excursionPrice = double.Parse(Console.ReadLine());

            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            int toyCount = puzzle + doll + bear + minion + truck;
            double finalPrice = puzzle * puzzlePrice + doll * dollPrice + bear * bearPrice + minion * minionPrice + truck * truckPrice;

            if (toyCount >= 50) 
            {
                finalPrice = finalPrice - (finalPrice * 0.25);
            }
            finalPrice = finalPrice - (finalPrice * 0.10);

            if (finalPrice >= excursionPrice)
            {
                Console.WriteLine("Да! Парите ще стигнат! " + (finalPrice - excursionPrice) + " лева остават");
            } else
            {
                Console.WriteLine("Опитай пак!" + (excursionPrice - finalPrice) + " лева трябват");
            }
        }
    }
}
