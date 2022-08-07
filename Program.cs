using System;

namespace EmployeeWage
{
    class Program
    {
        public const int isFullTime = 0;
        public const int isPartTime = 1;
        public const int WagePerHour = 20;
        public const int days = 20;
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
                    wage = emphr * WagePerHour;
                    Console.WriteLine("Employee is FullTime and Wage for Month is " + (emphr * wage));
                    break;
                case isPartTime:
                    emphr = 4;
                    wage = emphr * WagePerHour;
                    Console.WriteLine("Employee is PartTime and Wage for Month is " + (emphr * wage));
                    break;
                default:
                    emphr = 0;
                    break;
            }
        }
    }
}