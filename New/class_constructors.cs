/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;


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

