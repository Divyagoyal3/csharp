// See https://aka.ms/new-console-template for more information
using System;
class second
{
    public static  void Main ( String[] args)
    {
      first f1 = new first();
      f1.firstfun1();  
      
      Console.Title="First Site";
      Console.ForegroundColor=ConsoleColor.Green;


      Console.WriteLine("Hello, World!");
      
      
      // Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

      Console.WriteLine("Day 2 Learning with C#");
      Console.ReadLine();
    }



}

