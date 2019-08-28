﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.ex_Stack_Queue
{
    public class StackQueue
    {
        public static void Main()
        {
            Stack<int> Money = new Stack<int>();
            Money.Push(500);
            Money.Push(200);
            Money.Push(100);

            Console.WriteLine("----------------------");
            foreach(var item in Money)
            {
                Console.WriteLine(" item: {0}", item);
            }
            Console.WriteLine(" item on the top : {0}", Money.Peek());


            Console.WriteLine("----------------------");
            Queue<string> Tasks = new Queue<string>();
            Tasks.Enqueue("Build project structor");
            Tasks.Enqueue("Tasks separate");
            Tasks.Enqueue("Assign tasks");
            foreach (var item in Tasks)
            {
                Console.WriteLine(" item: {0}", item);
            }
            Console.WriteLine(" item on the top : {0}", Tasks.Peek());
        }
    }
}
