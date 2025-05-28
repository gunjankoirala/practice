using System;
static class StudentInfo
{
    public static String Name="Gunjan";
    public static String Address="Karra";

    public static void DisplayInfo()
    {
        Console.WriteLine("This is a Static method");
    }
}
public class DriverClass{
    public static void Main(String[] args)
    {
        StudentInfo.DisplayInfo();

        Console.WriteLine("Name of the student is :" + StudentInfo.Name);
        Console.WriteLine("Student Lives in :" +StudentInfo.Address);


    }
}