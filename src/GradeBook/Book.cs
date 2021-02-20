using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public string Name;
        public List<double> grades = new List<double>();
        private Statistics statistics;

        public Book(string name)
        {
            Name = name;
        }

        public void GetStatistics()
        {
            statistics = new Statistics(grades);
            Console.WriteLine($"Low grade: {statistics.Low}");
            Console.WriteLine($"High grade: {statistics.High}");
            Console.WriteLine($"Average grade: {statistics.Average:N1}");
            Console.WriteLine($"Letter: {statistics.Letter}");
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine($"Added grade {grade} to GradeBook.");
        }
    }
}
