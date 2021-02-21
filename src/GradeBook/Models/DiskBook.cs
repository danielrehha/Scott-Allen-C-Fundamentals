using System;
using System.Collections.Generic;
using System.IO;

namespace GradeBook
{
    public class DiskBook : Book
    {
        private string FilePath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).ToString();
        private Statistics Statistics;

        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override async void AddGrade(double grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                if (File.Exists($"{FilePath}/{Name}.txt"))
                {
                    using StreamWriter file = new($"{FilePath}/{Name}.txt", append: true);
                    await file.WriteLineAsync(grade.ToString());
                } else
                {
                    await File.WriteAllTextAsync($"{FilePath}/{Name}.txt", grade.ToString());
                }   
            } else
            {
                throw new ArgumentException();
            }
        }

        public override void GetStatistics()
        {
            List<double> grades = new List<double>();

            string[] gradesAsString = File.ReadAllLines($"{FilePath}/{Name}.txt");
            foreach(var grade in gradesAsString)
            {
                grades.Add(double.Parse(grade));
            }

            Statistics = new Statistics(grades);

            Console.WriteLine($"Low grade: {Statistics.Low}");
            Console.WriteLine($"High grade: {Statistics.High}");
            Console.WriteLine($"Average grade: {Statistics.Average:N1}");
            Console.WriteLine($"Letter: {Statistics.Letter}");
        }
    }
}
