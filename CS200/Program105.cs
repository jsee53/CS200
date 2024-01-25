using System;
using System.Collections;

namespace CS200
{
    public class ReverseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            return string.Compare(s2, s1);
        }
    }

    internal class Program105
    {
        public static void Solve105()
        {
            string[] animalsEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse", "horse", "deer" };
            string[] animalsKo = { "개", "소", "토끼", "염소", "양", "쥐", "말", "사슴" };

            Display("초기 배열", animalsEn);
            Array.Sort(animalsEn);
            Array.Reverse(animalsEn);
            Display("Sort()후 Reverse()", animalsEn);

            Display("초기 배열", animalsKo);
            Array.Sort(animalsKo, 2, 3);
            Display("[2]에서 3개 정렬 후", animalsKo);

            IComparer revComparer = new ReverseComparer();

            Array.Sort(animalsKo, revComparer);
            Display("내림차순 정렬", animalsKo);
        }

        private static void Display(string comment, string[] arr)
        {
            Console.WriteLine(comment);
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.Write("   {0}", arr[i]);
            }
            Console.WriteLine();
        }
    }
}