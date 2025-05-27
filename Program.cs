
using System;

namespace firstOne
{
    class Program
    {
    
            public double length;
            public double breadth;


            public double getArea()
            {
                return length*breadth;
            }
            public void display(){
                Console.WriteLine("length "+length);
                Console.WriteLine("Breadth "+breadth);
                Console.WriteLine("Area "+getArea());
            }
    
    }
    class exeRect{
        static void Main(string[] args){
            Program r = new Program();
            r.length =4;
            r.breadth=5;
            r.display();
            Console.ReadLine();

        }

    }
}
