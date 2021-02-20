using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void StatisticsHigh()
        {
            //arrange
            var book = new Book("New book");
            book.AddGrade(23.2);
            book.AddGrade(12.4);
            book.AddGrade(32.1);
            //act
            book.GetStatistics();
            var result = book.Statistics;
            //assert
            Assert.Equal(32.1, result.High);
        }

        [Fact]
        public void StatisticsLow()
        {
            //arrange
            var book = new Book("New book");
            book.AddGrade(23.2);
            book.AddGrade(12.4);
            book.AddGrade(32.1);
            //act
            book.GetStatistics();
            var result = book.Statistics;

            //assert
            Assert.Equal(12.4, result.Low);
        }
        [Fact]
        public void StatisticsAvg()
        {
            //arrange
            var book = new Book("New book");
            book.AddGrade(23.2);
            book.AddGrade(12.4);
            book.AddGrade(32.1);
            //act
            book.GetStatistics();
            var result = book.Statistics;

            var expected = (23.2 + 12.4 + 32.1) / 3;
            //assert
            Assert.Equal(expected, result.Average);
        }

        [Fact]
        public void StatisticsLetter()
        {
            var book = new Book("New book");
            book.AddGrade(92.0);
            book.AddGrade(65.0);
            book.AddGrade(50.0);

            book.GetStatistics();
            var result = book.Statistics;

            Assert.Equal('D', result.Letter);
        }
    }
}
