﻿namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            Stack<char> chars = new Stack<char>();

            for (int i = 0; i < text.Length; i++)
            {
                chars.Push(text[i]);
            }
            
            while (chars.Count!=0)
            {
                Console.Write(chars.Pop());
            }
        }
    }
}