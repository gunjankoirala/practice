using System;

    public class Person{
        public virtual void introduce(){
            Console.WriteLine("HI this is gunjan");
        }
    }
    public class Student : Person{
        
        public  override void introduce()
        {
            base.introduce();
            Console.WriteLine("HI this is student");
        }
    }
     
     public class Super{
        public static void Main(String[] args)
        {
            Student s = new Student();
            s.introduce();
        }
     }
