public class Car {
    public string model ="";
    public int year;

    public void DisplayInfo() {
        Console.WriteLine($"Model: {model}, Year: {year}");
    }
}

public class Demo{
    public static void Main(String[] args)
    {
        Car myCar = new Car(); 
        myCar.model = "Tesla";
        myCar.year = 2024;
        myCar.DisplayInfo();
    }
}

