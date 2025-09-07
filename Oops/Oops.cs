//Class and Object

//Class → Blueprint/template that defines properties (fields) and behaviors (methods).
//Object → Instance of a class.

using System;

class Car
{
    public string Brand;
    public int Year;

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of Car
        Car car1 = new Car();
        car1.Brand = "Tesla";
        car1.Year = 2023;
        car1.DisplayInfo();

        Car car2 = new Car();
        car2.Brand = "BMW";
        car2.Year = 2022;
        car2.DisplayInfo();
    }
}



