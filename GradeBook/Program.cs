﻿using System;

using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("Luigi's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();

            Console.ReadLine();   

        }

        
    }
}
