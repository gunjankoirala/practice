using System;

namespace inheritance
{
    public abstract class Salary
    {
        public abstract double CalculateSalary();
    }

    public class FullTime : Salary
    {
        public override double CalculateSalary()
        {
            double salary = 45000;
            return salary;
        }
    }

    public class PartTime : Salary
    {
        public override double CalculateSalary()
        {
            double salary = 4000;
            return salary;
        }
    }

    public class Demo
    {
        public static void Main(string[] args)
        {
            FullTime f = new FullTime();
            PartTime p = new PartTime();

            Console.WriteLine("FullTime salary: " + f.CalculateSalary());
            Console.WriteLine("PartTime salary: " + p.CalculateSalary());
        }
    }
}
