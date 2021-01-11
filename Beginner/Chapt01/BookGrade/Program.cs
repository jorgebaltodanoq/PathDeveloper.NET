using System;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace PathDeveloper.NET
{
    class Program
    {
        static void Main(string[] args)
        {
          var book = new Book("Cien Años Soledad.");
        
           //Add Note at book
           book.AddNote(15.5);
           book.AddNote(20.14);
           book.AddNote(11.63);
           book.AddNote(10.2);
           book.AddNote(18.15);
           book.AddNote(11.3);
           book.AddNote(12.25); 

           //Calculate statistics
           book.ShowStatistcs();
        
        }
    }
}
