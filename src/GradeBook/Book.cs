using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public string Name;
        public List<double> grades = new List<double>();

        public Book(string name)
        {
            Name = name;
        }

        public Statistics GetStatistics()
        {
            return new Statistics(grades);
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine($"Added grade {grade} to GradeBook.");
        }
    }
}
