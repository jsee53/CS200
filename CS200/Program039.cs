using System;

namespace CS200
{
    internal class Program039
    {
        public static void Solve039()
        {
            int i = 123;
            object o = i;
            i = i + 10;
            int j = (int)o;

            Console.WriteLine("The value-type value i = {0}", i);
            Console.WriteLine("The object-type value o = {0}", o);
            Console.WriteLine("The value-type value j = {0}", j);

            object p = o;
            o = 100;
            Console.WriteLine("The object=type value o = {0}", o);
            Console.WriteLine("The object=type value p = {0}", p);
        }
    }
}