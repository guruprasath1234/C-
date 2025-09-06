//hello world

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}



//variables and data types

int age = 20;            // Integer
double pi = 3.14;        // Floating point
char grade = 'A';        // Character
string name = "Guru";    // Text
bool isStudent = true;   // Boolean

//input/output

Console.Write("Enter your name: ");
string userName = Console.ReadLine();
Console.WriteLine("Hello " + userName);


//operators

int a = 10, b = 3;
Console.WriteLine(a + b);  // Addition
Console.WriteLine(a - b);  // Subtraction
Console.WriteLine(a * b);  // Multiplication
Console.WriteLine(a / b);  // Division
Console.WriteLine(a % b);  // Modulus


//conditions

int age = 18;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are underage.");
}


//loops

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Number: " + i);
}


//while loop

int count = 1;
while (count <= 5)
{
    Console.WriteLine("Count: " + count);
    count++;
}

//method functions

static int Add(int x, int y)
{
    return x + y;
}

static void Main()
{
    int result = Add(5, 10);
    Console.WriteLine("Sum = " + result);
}


//Oops

class Car
{
    public string Brand;
    public int Year;

    public void Drive()
    {
        Console.WriteLine(Brand + " is driving...");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Brand = "Tesla";
        myCar.Year = 2024;
        myCar.Drive();
    }
}
