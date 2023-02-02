﻿using System;
using System.Collections.Generic;
using System.Linq;

int count = int.Parse(Console.ReadLine());

Stack<int> numbers = new();

for (int i = 0; i < count; i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    int command = tokens[0];

    switch (command)
    {
        case 1: 
            int number = tokens[1];
            numbers.Push(number);
            break;
        case 2:
            if (numbers.Any())
            {
                numbers.Pop();
            }
            break;
        case 3:
            if (numbers.Any()) //or numbers.Count > 0;
            {
                Console.WriteLine(numbers.Max());
            }
            break;
        case 4:
            if (numbers.Any())
            {
                Console.WriteLine(numbers.Min());  
            }
            break;
    }
}
Console.WriteLine(string.Join(", ", numbers));
