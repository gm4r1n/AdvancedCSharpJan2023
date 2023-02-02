﻿using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(children);
            int numberOfTosses = int.Parse(Console.ReadLine());
            int tosses = 1;

            while (queue.Count != 1)
            {
                string child = queue.Dequeue();
                if (tosses < numberOfTosses)
                {
                    tosses++;
                    queue.Enqueue(child);
                }
                else
                {
                    Console.WriteLine($"Removed {child}");
                    tosses = 1;
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
