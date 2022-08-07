using System;

namespace EmployeeWage
{
    class Program
    {
        public const int isFullTime = 0;
        public const int isPartTime = 1;
        public const int WagePerHour = 20;
        static void Main(string[] args)
        {
            int emphr;
            Random random = new Random();
            int value = random.Next(0, 2);


            switch (value)
            {
                case isFullTime:
                    emphr = 8;
                    Console.WriteLine("Employee is FullTime and Wage is " + (emphr * WagePerHour));
                    break;
                case isPartTime:
                    emphr = 4;
                    Console.WriteLine("Employee is PartTime and Wage is " + (emphr * WagePerHour));
                    break;
                default:
                    emphr = 0;
                    break;
            }
        }
    }
}