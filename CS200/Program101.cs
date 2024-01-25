using System;

namespace CS200
{
    internal class Program101
    {
        public static void Solve101()
        {
            Random r = new Random();
            MyQueue<float> que = new MyQueue<float>();

            for (int i = 0; i < 5; i++)
                que.EnQueue(new Node<float>(r.Next(100) / 100.0F));
            que.Print();

            for (int i = 0; i < 3; i++)
                Console.WriteLine("DeQueue: {0}", que.DeQueue());
            que.Print();
        }
    }
}