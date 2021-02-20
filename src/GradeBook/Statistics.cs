using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Statistics
    {
        public double Average;
        public double High;
        public double Low;

        public Statistics(List<double> grades)
        {
            Calculate(grades);
        }

        private void Calculate(List<double> grades)
        {
            Low = double.MaxValue;
            High = double.MinValue;
            var sum = 0.0;
            foreach (var grade in grades)
            {
                High = Math.Max(grade, High);
                Low = Math.Min(grade, Low);
                sum += grade;
            }
            Average = sum / grades.Count;
        }
    }
}
