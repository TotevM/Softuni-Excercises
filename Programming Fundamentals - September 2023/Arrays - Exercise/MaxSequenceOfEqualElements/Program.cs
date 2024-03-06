﻿using System;
using System.Linq;
namespace Max_sequence_of_equal_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = 0;
            int length = 1;
            int beststart = 0;
            int bestLength = 1;

            for (int i = 1; i <= input.Length - 1; i++)
            {
                if (input[i] == input[i - 1])
                {
                    length++;
                }
                else
                {
                    if (length > bestLength)
                    {
                        bestLength = length;
                        length = 1;
                        beststart = start;
                        start = i;
                    }
                    else if (length == bestLength)
                    {
                        length = 1;
                        start = i;
                    }
                    else
                    {
                        length = 1;
                        start = i;
                    }
                }
            }

            if (length > bestLength)
            {
                bestLength = length;

                beststart = start;
            }

            if (bestLength == 1)
            {
                Console.WriteLine(input[0]);
                return;
            }

            var result = string.Concat(input);
            var sub = result.Substring(beststart, bestLength).Trim();
            //var final = sub.ToCharArray();
            var final = input.Skip(beststart).Take(bestLength).ToArray();
            Console.WriteLine(string.Join(" ", final));
        }
    }
}