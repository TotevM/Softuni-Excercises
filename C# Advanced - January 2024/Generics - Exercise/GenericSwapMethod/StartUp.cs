﻿namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Box<int> box = new();

            for (int i = 0; i < lines; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }

            int[] indexSwap = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexSwap[0];
            int secondIndex = indexSwap[1];
            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
