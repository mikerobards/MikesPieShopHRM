﻿using System;

namespace MikesPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 1234;
            int months = 12, bonus = 1000;

            bool isActive = true;
            double rating = 99.25;

            double ratePerHour = 12.34;
            int numberOfHoursWorked = 165;

            double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

            Console.WriteLine(currentMonthWage);

            ratePerHour += 3;

            if(currentMonthWage > 2000)
            {
                Console.WriteLine("Top paid employee");
            }

            int numberOfEmployees = 15;
            numberOfEmployees--;

            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;

            char userSelection = 'a';
            char upperVersion = char.ToUpper(userSelection);
            bool isDigit = char.IsDigit(userSelection);
            bool isLetter = char.IsLetter(userSelection);

            DateTime someDateTime = new DateTime(2021, 03, 28);
            DateTime today = DateTime.Today;
            DateTime twoDaysLater = someDateTime.AddDays(2);
            DayOfWeek day = someDateTime.DayOfWeek;
            bool isDST = someDateTime.IsDaylightSavingTime();
            Console.WriteLine(today);



            Console.ReadLine();
        }
    }
}
