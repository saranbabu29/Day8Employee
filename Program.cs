using System;

namespace EmployeeWage
{
    class Program
    {
        public const int isFullTime = 0;
        public const int isPartTime = 1;
        public const int WagePerHour = 20;
        public const int totalHours = 100;
        static void Main(string[] args)
        {
            int emphr;
            int wage;
            Random random = new Random();
            int value = random.Next(0, 2);


            switch (value)
            {
                case isFullTime:
                    emphr = 8;
                    wage = totalHours * WagePerHour;
                    Console.WriteLine("Employee is FullTime and Wage is " + (emphr * wage));
                    break;
                case isPartTime:
                    emphr = 4;
                    wage = totalHours * WagePerHour;
                    Console.WriteLine("Employee is PartTime and Wage is " + (emphr * wage));
                    break;
                default:
                    emphr = 0;
                    break;
            }
        }
    }
}