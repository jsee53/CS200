using System;

namespace CS200
{
    internal class Program099
    {
        public static void Solve099()
        {
            MyStack<int> stack = new MyStack<int>();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                int val = r.Next(100);
                stack.Push(val);
                Console.Write("Push(" + val + ") ");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Pop()=" + stack.Pop() + ", ");
            }
        }
    }
}