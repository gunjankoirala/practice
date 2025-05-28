using System;

interface IAnimal
{
     void MakesSound();
}
public class Cow : IAnimal
{
    public void MakesSound()
    {
        Console.WriteLine("the cow moos");
    }
}
public class Snake :IAnimal
{
    public void MakesSound()
    {
        Console.WriteLine("the Snake Hissss");
    }
}
public class ImplementInterface
{
    public static void Main(String[] args){
    Snake snake =new Snake();
    snake.MakesSound();
    Cow cow = new Cow();
    cow.MakesSound();
    }
}

