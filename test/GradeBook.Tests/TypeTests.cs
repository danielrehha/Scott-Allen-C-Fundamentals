using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = new InMemoryBook("Book 1");
            SetName(book1, "New name");

            Assert.Equal("New name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void CannotSetNameFromNewValue()
        {
            var book1 = new InMemoryBook("Book 1");
            GetBookSetName(book1, "New Book");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book1, string name)
        {
            book1 = new InMemoryBook(name);
            book1.Name = name;
        }

        [Fact]
        public void SetValueByReference()
        {
            var x = 3;
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        [Fact]
        public void SetValueNewValue()
        {
            var x = 3;
            SetIntNewValue(x);

            Assert.Equal(3, x);
        }

        private void SetIntNewValue(int x)
        {
            x = 42;
        }
    }
}
