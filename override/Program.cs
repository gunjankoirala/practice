using System;


    public class Shape
    {
        public virtual double area()
        {
            return 0;
        }
    }

    public class Rectangle : Shape
    {
        public int length, breadth;

        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }

        public override double area()
        {
            return length * breadth;
        }
    }

    public class Circle : Shape
    {
        public int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public override double area()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Execute
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 10);
            Circle c = new Circle(7);

            Console.WriteLine("Rectangle area: " + r.area());
            Console.WriteLine("Circle area: " + c.area());
        }
    }


