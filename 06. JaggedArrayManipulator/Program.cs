﻿using System;
using System.Linq;

int rows = int.Parse(Console.ReadLine());

int[][]  jaggedArray= new int[rows][]; //we only declare the rows because every row can be with different length

for (int row = 0; row < rows; row++)
{
    int[] cols = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    jaggedArray[row] = cols;
}

for (int row = 0; row < rows - 1; row++)  
{
    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] *= 2;
            jaggedArray[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] /= 2;
        }
        for (int col = 0; col < jaggedArray[row + 1].Length; col++)
        {
            jaggedArray[row + 1][col] /= 2;
        }
    }
}

while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        break;
    }

    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);

    if (tokens[0] == "Add")
    {
        if (IsInArray(row, col, jaggedArray)) //equialent to the next if-statament but extracted into method
        {
            jaggedArray[row][col] += value;
        }
    }
    else
    {
        if (row >= 0 && row < jaggedArray.Length
            && col >= 0
            && col < jaggedArray[row].Length)
        {
            jaggedArray[row][col] -= value;
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write($"{jaggedArray[row][col]} ");
    }
    Console.WriteLine();
}

static bool IsInArray(int row, int col, int[][] jaggedArray)
{
    return row >= 0 && row < jaggedArray.Length
                && col >= 0
                && col < jaggedArray[row].Length;
}