using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasksArr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Stack<int> tasks = new Stack<int>(tasksArr);

            int[] threadsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> threads = new Queue<int>(threadsArr);

            int taskToKill = int.Parse(Console.ReadLine());

            while (true)
            {
                int n = tasks.Peek();
                int m = threads.Peek();
                if (threads.Peek()>=tasks.Peek())
                {
                    if (tasks.Peek() == taskToKill)
                    {
                        Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToKill}");
                        break;
                    }
                    threads.Dequeue();
                    tasks.Pop();
                }
                else
                {
                    if (tasks.Peek()==taskToKill)
                    {
                        Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToKill}");
                        break;
                    }
                    threads.Dequeue();
                    
                }
            }
            Console.WriteLine(string.Join(" ",threads));

        }
    }
}
