using System;
using System.Linq;
using System.Collections.Generic;

int[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int elementsToPush = tokens[0];
int elementsToPop = tokens[1];
int number = tokens[2];

Stack<int> stack = new Stack<int>();
//var stack = new Stack<int>();

for (int i = 0; i < elementsToPush; i++)
{
    stack.Push(numbers[i]);
}

for (int j = 0; j < elementsToPop; j++)
{
    stack.Pop();
}

if (stack.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if (stack.Any()) //if there are any ellements in the stack
    {
        Console.WriteLine(stack.Min()); //gives the lowest element of the stack
    }
    else
    {
        Console.WriteLine(0);
    }
}