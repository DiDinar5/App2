using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name:");
        string name = Console.ReadLine();
        Console.Write("Enter your age:");
        byte age=(byte) int.Parse(Console.ReadLine());
        Console.WriteLine("Your name is {0} and age is {1}",name,age);
        Console.Write("Enter your birthdate:");
        string birthdate=Convert.ToString(Console.ReadLine());
        Console.WriteLine("Your birthdate is {0}",birthdate);
        Console.ReadKey();
    }

}

    