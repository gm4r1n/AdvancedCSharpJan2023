using System;
using System.Collections.Generic;

string parenthesis = Console.ReadLine();

Stack<char> stack = new();

foreach (char parenthese in parenthesis)
{
    switch (parenthese)
    {
        case '(':
        case '[':
        case '{':
            stack.Push(parenthese);
            break;
        case ')':
            if (stack.Count == 0 || stack.Pop() != '(')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case ']':
            if (stack.Count == 0 || stack.Pop() != '[')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case '}':
            if (stack.Count == 0 || stack.Pop() != '{')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
    }
}

if (stack.Count > 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}
