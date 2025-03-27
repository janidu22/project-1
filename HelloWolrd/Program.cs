using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("enter a number between 1-5 to verify if you are a human: ");
        int Number = int.Parse(Console.ReadLine());
        if (Number > 1 && Number < 5)
        {
            Console.WriteLine("user verified");
        }
        else
        {
            Console.WriteLine("try again");
        }
    }
}
