using System;
using System.Text;

namespace MikesPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the wage: ");
            string wage = Console.ReadLine();

            //int wageValue = int.Parse(wage);

            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing success: " + wageValue);
            else
                Console.WriteLine("Parsing failed");



            //string firstName = "Bethany";
            //string lastName = "Smith";

            //StringBuilder builder = new StringBuilder();

            //builder.Append("Last name:");
            //builder.AppendLine(lastName);
            //builder.Append("First name:");
            //builder.Append(firstName);
            //string result = builder.ToString();

            //Console.WriteLine(result);

            //string fullName = firstName + " " + lastName;
            //string employeeID = string.Concat(firstName, lastName);

            //string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

            //int length = empId.Length;

            //string subString = fullName.Substring(1, 3);
            //Console.WriteLine($"Characters 2 to 4 of fullName are {subString}");


            //string fullName = "Bethany Smith";

            //string noValueString = null;
            //string s;

            //s = firstName;

            //var userName = "BethanyS";

            //string displayName = $"Welcome!\n{firstName}\t{lastName}";

            //Console.WriteLine(displayName);

            //string verbatePath = @"C:\data\employeelist.xlsx";

            //string dblQuotes = "My name is \"Harry\"";

            //Console.WriteLine(dblQuotes);

            //string name = "Bethany";
            //string anotherName = name;

            //name += " Smith";

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Another name: " + anotherName);

            //string lowerCase = name.ToLower();





            
            Console.ReadLine();
        }


        //static void Main(string[] args)
        //{
        //    var monthlyWage = 1234;
        //    int months = 12, bonus = 1000;

        //    var isActive = true;
        //    var rating = 99.25;

        //    double ratePerHour = 12.34;
        //    int numberOfHoursWorked = 165;

        //    long veryLongMonth = numberOfHoursWorked;
        //    double d = 123456789.0;
        //    int x = (int) d;

        //    int intVeryLongMonth = (int) veryLongMonth;

        //    double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

        //    //Console.WriteLine(currentMonthWage);

        //    ratePerHour += 3;

        //    if(currentMonthWage > 2000)
        //    {
        //        //Console.WriteLine("Top paid employee");
        //    }

        //    int numberOfEmployees = 15;
        //    numberOfEmployees--;

        //    int intMaxValue = int.MaxValue;
        //    int intMinValue = int.MinValue;

        //    char userSelection = 'a';
        //    char upperVersion = char.ToUpper(userSelection);
        //    bool isDigit = char.IsDigit(userSelection);
        //    bool isLetter = char.IsLetter(userSelection);

        //    DateTime someDateTime = new DateTime(2021, 03, 28);
        //    DateTime today = DateTime.Today;
        //    DateTime twoDaysLater = someDateTime.AddDays(2);
        //    DayOfWeek day = someDateTime.DayOfWeek;
        //    bool isDST = someDateTime.IsDaylightSavingTime();
        //    //Console.WriteLine(today);

        //    DateTime hireDate = new DateTime(2021, 3, 28, 14, 30, 0);

        //    //Console.WriteLine(hireDate);

        //    DateTime exitDate = new DateTime(2021, 12, 11);

        //    //DateTime invalidDate = new DateTime(2021, 15, 11);

        //    DateTime startDate = hireDate.AddDays(15);

        //    DateTime currentDate = DateTime.Now;
        //    bool areWeInDst = currentDate.IsDaylightSavingTime();

        //    DateTime startHour = DateTime.Now;
        //    TimeSpan workTime = new TimeSpan(8, 35, 0);
        //    DateTime endHour = startHour.Add(workTime);

        //    Console.WriteLine(startHour.ToLongDateString());
        //    Console.WriteLine(endHour.ToShortTimeString());





        //    Console.ReadLine();
        //}
    }
}
