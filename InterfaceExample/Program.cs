using System;
interface Flyable{
    void Fly();
}
interface Swimmable
{
    void Swim();

}
public class Crow : Flyable
{
    public void Fly()
    {
        Console.WriteLine("The crow can Fly only");
    }
}
public class Duck : Flyable,Swimmable
{
    public void Fly()
    {
        Console.WriteLine("The duck can Fly ");
    }
     public void Swim()
    {
        Console.WriteLine("The duck can Swim as well ");
    }
}
public class InterfaceExample
{
    public static void Main(String[] args)
    {
        Duck d = new Duck();
        d.Fly();
        d.Swim();
        Crow c = new Crow();
        c.Fly();
    }
}

 
