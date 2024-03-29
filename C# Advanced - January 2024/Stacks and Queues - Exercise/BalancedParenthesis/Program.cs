﻿namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthesStack = new Stack<char>();

            foreach (var symbol in input)
            {
                if (parenthesStack.Any())
                {
                    char check = parenthesStack.Peek();
                    if ((check == '{' && symbol == '}')
                        || (check == '[' && symbol == ']')
                        || (check == '(' && symbol == ')'))
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                }
                parenthesStack.Push(symbol);
            }
            Console.WriteLine(!parenthesStack.Any() ? "YES" : "NO");
        }
    }
}
