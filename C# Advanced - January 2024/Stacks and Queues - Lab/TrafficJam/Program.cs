﻿using System.Data;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars= new Queue<string>();
            int passedCars = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    if (cars.Count>=n)
                        {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                    else
                    {
                        while (cars.Count!=0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                    }

                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}