using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1;
            int wagePerHour = 20;
            int empHr;
            int dailyWage;

            Random random = new Random();
            int value = random.Next(0, 2);

            if (value == isPartTime)
            {
                empHr = 8;
                Console.WriteLine("Employee is Full Time");
                dailyWage = empHr * wagePerHour;
                Console.WriteLine("Employee Wage is " + dailyWage);
            }
            else
            {
                empHr = 4;
                Console.WriteLine("Employee is Part Time");
                dailyWage = empHr * wagePerHour;
                Console.WriteLine("Employee Wage is " +dailyWage);
            }
        }
    }
}