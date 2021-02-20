using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Statistics
    {
        public double Average;
        public double High;
        public double Low;
        public char Letter;

        public Statistics(List<double> grades)
        {
            Calculate(grades);
        }

        private void Calculate(List<double> grades)
        {
            Low = double.MaxValue;
            High = double.MinValue;
            Average = 0.0;
            foreach (var grade in grades)
            {
                High = Math.Max(grade, High);
                Low = Math.Min(grade, Low);
                Average += grade;
            }
            Average /= grades.Count;
            Letter = AssociateLetter(average: Average);
        }

        private char AssociateLetter(double average)
        {
            switch(average)
            {
                case var a when a >= 90.0:
                    return 'A';
                case var a when a >= 80.0:
                    return 'B';
                case var a when a >= 70.0:
                    return 'C';
                case var a when a >= 60.0:
                    return 'D';
                default:
                    return 'F';
            }
        }
        
    }
}
