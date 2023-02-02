using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] commArgs = command.Split();
                if (commArgs[0] == "add")
                {
                    int first = int.Parse(commArgs[1]);
                    int second = int.Parse(commArgs[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                if (commArgs[0] == "remove")
                {

                    int numsToRemove = int.Parse(commArgs[1]);
                    if (numsToRemove < stack.Count)
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            //Console.WriteLine(stack.Sum());
            int sum = 0;

            while (stack.Count != 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
