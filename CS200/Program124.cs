﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CS200
{
    class Student124
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Scores { get; set; }
    }

    internal class Program124
    {
        static List<Student124> students;

        public static void Solve124()
        {
            students = new List<Student124>
                {
                    new Student124
                    {
                        Name = "PjKim",
                        Id = 19001001,
                        Scores = new List<int> { 86, 90, 76 }
                    },
                    new Student124
                    {
                        Name = "BsKim",
                        Id = 19001002,
                        Scores = new List<int> { 56, 92, 93 }
                    },
                    new Student124
                    {
                        Name = "YsCho",
                        Id = 19001003,
                        Scores = new List<int> { 69, 85, 75 }
                    },
                    new Student124
                    {
                        Name = "BiKang",
                        Id = 19001004,
                        Scores = new List<int> { 88, 80, 57 }
                    }
            };

            var result = from student in students
                         group student by student.Scores.Average() >= 80 into g
                         select new
                         {
                             key = g.Key == true ? "80점 이상" : "80점 미만",
                             count = g.Count(),
                             avr = g.Average(Student => Student.Scores.Average()),
                             max = g.Max(Student => Student.Scores.Average())
                         };
            foreach (var item in result)
            {
                Console.WriteLine("{0} : 학생 수 = {1}", item.key, item.count);
                Console.WriteLine("{0} : 평균 점수 = {1:F2}", item.key, item.avr);
                Console.WriteLine("{0} : 최고 점수 = {1:F2}", item.key, item.max);
                Console.WriteLine();
            }
        }
    }
}