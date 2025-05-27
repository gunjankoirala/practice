using System;

namespace CalculatorExample
{
    public class Calculator
    {
        
        public int Add(int a, int b)
        {
            return a + b;
        }

        
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

       
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Add 2 integers: " + calc.Add(5, 10));             
            Console.WriteLine("Add 3 integers: " + calc.Add(5, 10, 15));         
            Console.WriteLine("Add 2 doubles: " + calc.Add(5.5, 10.2));          
        }
    }
}
