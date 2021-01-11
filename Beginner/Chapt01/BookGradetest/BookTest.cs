using System;
using PathDeveloper.NET;
using Xunit;

namespace BookGradetest
{
    public class BookTest
    {
        [Fact]
        public void BookCalculateAverageGrade()
        {
            // arrange
            var book = new Book("Roap map developer NET");
            book.AddNote(15.5);
            book.AddNote(20.14);
            book.AddNote(11.63);
            book.AddNote(10.2);
            book.AddNote(18.15);
            book.AddNote(11.3);
            book.AddNote(12.25);

            // act 
            var result = book.GetStatistcs();

            // assert
            Assert.Equal(14.2, result.Average , 1);
            Assert.Equal(10.2 , result.Low , 1);
            Assert.Equal(20.1, result.High , 1);

        }
    }
}
