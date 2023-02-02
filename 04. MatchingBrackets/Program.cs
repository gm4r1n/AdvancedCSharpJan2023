﻿using System;
using System.Collections.Generic;

namespace _04._MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> openBracketIndexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openBracketIndexes.Push(i);
                }
                if (expression[i] == ')')
                {
                    int openBracket = openBracketIndexes.Pop();
                    for (int j = openBracket; j <= i; j++)
                    {
                        Console.Write(expression[j]);
                    };

                    Console.WriteLine();
                }
            }
        }
    }
}
    