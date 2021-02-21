using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("GradeBook");
            book.GradeAdded += GradeAddedNotification;
            EnterGrades(book);

            //book.GetStatistics();
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            book.GetStatistics();
        }

        static void GradeAddedNotification(Object send, EventArgs args)
        {
            Console.WriteLine("Grade has been added!");
        }
    }
}
