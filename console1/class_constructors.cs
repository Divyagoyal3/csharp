/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Animal
{
    public static  int count =0;
    
    public string name ;
    public int age ;
    
    
        
    //constructors

    //overload
    public Animal(string s_names, int s_age)
    {
        name=s_names;
        age=s_age;
        
        
        count++;
    }
    // class Methods
      public void Print()
     {
         Console.WriteLine("Name:" +name);
         Console.WriteLine("Age:" +age);
   
     }
}
class HelloWorld {
    
    //Main method
  static void Main( string[] args)
  {
  
   
    Animal cat = new Animal("Hlo Constructors", 10);
    cat.Print();
    
    Console.WriteLine();
    
    Animal.count += 2;
    Console.WriteLine("Animal :" +Animal.count);
   
     
  }
}

