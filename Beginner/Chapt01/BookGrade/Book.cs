using System;
using System.Collections.Generic;
using static System.Console;
using static System.Math;
using PathDeveloper.NET;


namespace  PathDeveloper.NET
{
    public class Book
    {

        //Propiedad
        public string Name;
        private List<double> grades;

        //Instancia de clase..
        Statistics result = new Statistics();

        //Constructor
        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddNote(double value)
        {
            if (value <=100 && value >= 0)
            {
              grades.Add(value);
            }
           
        }

        public Statistics GetStatistcs()
        {
          result.Average = 0.0;
          result.High = double.MinValue;
          result.Low = double.MaxValue;

          var lengt = grades.Count;

          foreach (var number in grades)
          {
             result.High = Max(number ,  result.High);
             result.Low = Min(number , result.Low);
             result.Average += number;  
          }
           
           result.Average /= lengt;

         return  result;
        }

        public void ShowStatistcs()
        {
            //Calcular Estadisticas
            GetStatistcs();

            //Mostrar valores
            WriteLine($"The average is {result.Average}");
            WriteLine($"The grade High is {result.High}");
            WriteLine($"The grade Low  is {result.Low}");

        }
    }
}