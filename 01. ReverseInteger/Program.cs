using System;
using System.Collections.Generic;

namespace _01._ReverseInteger
{
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var characther in input)
            {
                stack.Push(characther);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
