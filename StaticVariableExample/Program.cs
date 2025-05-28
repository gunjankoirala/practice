using System;
public class StaticVariable
{
    public static int count;
     public int CountUp(int n)
        {
            return count++;

        }
     


}
public class StaticVariableDemo
{
    public static void Main(String[] args)
    {
        StaticVariable obj1 =new StaticVariable();
        StaticVariable obj2 = new StaticVariable();

        Console.WriteLine(obj1.CountUp(0));
        Console.WriteLine(obj2.CountUp(0));
        Console.WriteLine(StaticVariable.count);


    }
}