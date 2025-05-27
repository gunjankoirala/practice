using System;
namespace abstraction{
    public abstract class Sound{
        public  abstract void makeSound();
    }

    public class Cat : Sound{
        public override void makeSound()
        {
            Console.WriteLine("Cat Meows");
        }
    }

    public class Demo{
        public static void Main(String[] args)
        {
            Sound c= new Cat();
            c.makeSound();
        }
    }
}
