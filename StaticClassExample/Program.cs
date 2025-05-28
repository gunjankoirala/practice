using System;
static class Calculator
{
    
    public static double Square(int n)
    {
        return n*n;
    }
    public static double Cube(int n)
    {
        return n*n*n;

    }

}

public class StaticExample
{
    public static void Main(String[] args)
    {
        Console.WriteLine(Calculator.Square(3));

    }
}