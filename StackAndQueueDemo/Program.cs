using System;

namespace StackAndQueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack and Queue Demo!");

            StackCustom<int> stack = new StackCustom<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);

            Console.WriteLine("Display all Stack popped items:");
            int count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(stack.Pop());
            }


            //Reverse Polis Noation Calculator
            // ReversePolisCalculator.RPNCalculator();


            Console.WriteLine("Queue Samples");
            QueueCustom<int> queue = new QueueCustom<int>();
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(8);

            int queueCount = queue.Count;
            for (int i = 0; i < queueCount; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
