using System;
using System.Collections.Generic;
using System.Linq;

Queue<string> songs = new(
    Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    );

while (songs.Any()) //or songs.Count > 0;
{
    string[] comArgs = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = comArgs[0];

    switch (command)
    {
        case "Play":
            songs.Dequeue();
            break;
        case "Add":
            string song = string.Join(" ", comArgs.Skip(1));
            if (songs.Contains(song))
            {
                Console.WriteLine($"{song} is already contained!");
            }
            else
            {
                songs.Enqueue(song);
            }
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songs));
            break;
    }
}

Console.WriteLine("No more songs!");