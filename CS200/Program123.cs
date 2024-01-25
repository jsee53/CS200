using System;
using System.Collections.Generic;
using System.Linq;

namespace CS200
{
    class Student123
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Scores { get; set; }
    }

    internal class Program123
    {
        static List<Student123> students;

        public static void Solve123()
        {
            students = new List<Student123>
                {
                    new Student123
                    {
                        Name = "PjKim",
                        Id = 19001001,
                        Scores = new List<int> { 86, 90, 76 }
                    },
                    new Student123
                    {
                        Name = "BsKim",
                        Id = 19001002,
                        Scores = new List<int> { 56, 92, 93 }
                    },
                    new Student123
                    {
                        Name = "YsCho",
                        Id = 19001003,
                        Scores = new List<int> { 69, 85, 75 }
                    },
                    new Student123
                    {
                        Name = "BiKang",
                        Id = 19001004,
                        Scores = new List<int> { 88, 80, 57 }
                    }
            };

            Print(students);
            HighScore(0, 85);
            HighScore(1, 90);
        }

        private static void HighScore(int exam, int cut)
        {
            var highScores = from student in students
                             where student.Scores[exam] >= cut
                             select new { Name = student.Name, Score = student.Scores[exam] };

            Console.WriteLine($"{exam + 1}번째 시험에서 {cut} 이상의 점수를 받은 학생");
            foreach (var item in highScores)
                Console.WriteLine($"\t{item.Name,-10}{item.Score}");
        }

        private static void Print(List<Student123> students)
        {
            foreach (var item in students)
            {
                Console.Write($"{item.Id,-10}{item.Name,-10}");
                foreach (var score in item.Scores)
                    Console.Write($"{score,-5}");
                Console.WriteLine(item.Scores.Average().ToString("F2"));
            }
        }
    }
}