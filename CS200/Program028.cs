using System;

namespace CS200
{
    internal class Program028
    {
        public static void Solve028()
        {
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "cow";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}", s2, s1, b);

            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at index {1}", s2, index);
            }

            if (s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                Console.WriteLine("'{0}' is in the string '{1}'", s2, s1);
            }
        }
    }
}