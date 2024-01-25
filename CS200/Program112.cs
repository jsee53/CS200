using System;

namespace CS200
{
    class MyCollection<T>
    {
        private T[] array = new T[100];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }

    internal class Program112
    {
        public static void Solve112()
        {
            var myString = new MyCollection<string>();
            myString[0] = "Hello, World!";
            myString[1] = "Hello, C#";
            myString[2] = "Hello, Indexer!";

            for (int i = 0; i < 3; i++)
                Console.WriteLine(myString[i]);
        }
    }
}