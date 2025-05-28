using System;
// public class Box<T>
// {
    
//     public void DisplayItem(T item)
//     { 
//         Console.WriteLine("The box has " +item);
//     }

// }
// public class DriverClass{
//      public static void Main(String[] args)
//     {
//         Box<int> b= new Box<int>();
//         Box<String> s= new Box<String>();
//         s.DisplayItem("knife");
//         b.DisplayItem(5);
//     }
// }
using System;

public class SimpleList<T>
{
    private T[] items;
    private int count;       
    private int capacity;    

    public SimpleList(int initialCapacity = 4)
    {
        capacity = initialCapacity;
        items = new T[capacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == capacity)
        {
            Resize();
        }
        items[count] = item;
        count++;
    }

    private void Resize()
    {
        capacity *= 2;
        T[] newItems = new T[capacity];
        Array.Copy(items, newItems, count);
        items = newItems;
    }

    public void Display()
    {
        Console.Write("Items: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(items[i] + " ");
        }
        Console.WriteLine();
    }
}

public class DriverClass
{
    public static void Main(string[] args)
    {
        SimpleList<string> list = new SimpleList<string>();

        list.Add("Apple");
        list.Add("Banana");
        list.Add("Cherry");
        list.Add("Date");
        list.Add("Elderberry");  

        list.Display();
    }
}


