using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int EmpPresent = 1;
            int wagePerHour = 20;
            int empHr = 8;
            int dailyWage;

            Random random = new Random();
            int value = random.Next(0, 2);

            if (value == EmpPresent)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = empHr * wagePerHour;
                Console.WriteLine("Employee Wage is " + dailyWage);
            }
        }
    }
}
