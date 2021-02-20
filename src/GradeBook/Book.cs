using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(Object sender, EventArgs args);

    public class Book
    {
        public string Name;
        public List<double> grades = new List<double>();
        public Statistics Statistics;

        public Book(string name)
        {
            Name = name;
        }

        public void GetStatistics()
        {
            Statistics = new Statistics(grades);
            Console.WriteLine($"Low grade: {Statistics.Low}");
            Console.WriteLine($"High grade: {Statistics.High}");
            Console.WriteLine($"Average grade: {Statistics.Average:N1}");
            Console.WriteLine($"Letter: {Statistics.Letter}");
        }

        public void AddGrade(double grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            } else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public event GradeAddedDelegate GradeAdded;
    }
}
