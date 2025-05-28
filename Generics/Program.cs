using System;
public class Swap<T>
{

 public void DoSwap(ref T a, ref T  b)
 {
    T temp = a;
    a=b;
    b= temp;
 } 
}
public class GenericsExample{
    public static void Main(String[] args)
    {
        int x= 4;
        int y= 5;
        Console.WriteLine("Before Swap: X = " + x + ", Y = " + y);
        Swap<int> s =new Swap<int>();
        s.DoSwap(ref x,ref y);
        Console.WriteLine("After Swap :X= "+ x + ",Y= " +y );


        
        
    }
}