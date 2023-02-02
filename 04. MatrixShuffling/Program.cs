using System;
using System.Linq;

int[] dimensions = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];


string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] strings = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = strings[col];
    }
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    //string command = Console.ReadLine();
    //if (command == "END")
    //{
    //    break;
    //}
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (IsValidCommand(rows, cols, tokens))
    {
        string tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
        matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
        matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;

        PrintMatrix(matrix); //can skip the matrix because it's in the outhermost scope(the main method scope)
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}

bool IsValidCommand(int rows, int cols, string[] tokens)
    {
    return
        tokens[0] == "swap"
        && tokens.Length == 5
            && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows
            && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols
            && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows
            && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols;
    }

void PrintMatrix(string[,] matrix) //can skip string[,] matrix because it's in the outhermost scope(the main method scope)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}