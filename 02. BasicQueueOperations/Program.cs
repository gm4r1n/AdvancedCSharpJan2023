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

int elementsToDequeue = tokens[1];
int number = tokens[2];

Queue<int> queue = new(numbers); //syntax suggar, the new Queue() can be skipped | we can put a collection in the parenthesis, because Queue accepts iEnumerable

for (int i = 0; i < elementsToDequeue; i++)
{
    queue.Dequeue();
}
if (queue.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Any())
    {
        Console.WriteLine(queue.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}