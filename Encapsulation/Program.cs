using System;
namespace Encapsulation
{
    public class Student
    {
        private String name ="";
        private String address="";
         public void setName(string n)
         {
            name = n;
         }
         public String getName()
         {
            return name;
         }
         public void setAddress(string a)
         {
            address = a;
         }
         public String getAddress()
         {
            return address;
         }

    }

    public class Demo
    {
        public static void Main(String[] args)
        {
            Student s = new Student();
            s.setAddress("hetauda");
            s.setName("Gunjan");
            Console.WriteLine("Name " + s.getName());
            Console.WriteLine("Address " + s.getAddress());
        }
    }
}
