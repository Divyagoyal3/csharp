// See https://aka.ms/new-console-template for more information
using System;
class second
{
    public static  void Main ( String[] args)
    {
      first f1 = new first();
      Console.WriteLine("Enter Your Choice:");
      int d= Convert.ToInt32(Console.ReadLine());
      switch(d)
      {
      case 1:
     // code block
      f1.firstfun1();
     break;
     case 2:
    // code block
    f1.inputs();
    break;
     case 3:
     // code block
      f1.conversions();
     break;
     case 4:
    // code block
    f1.conditions();
    break;
     case 5:
    // code block
    f1.looping();
    break;
    case 6:
    f1.looks();
    break;
     case 7:
    // code block
    f1.arrays();
    break;
     case 8:
    // code block
    f1.learnarray();
    break;
     case 9:
    // code block
    f1.dynamicarray();
    break;
  default:
    // code block
    Console.WriteLine("OOPs! wrong input");
    break;
      }
    }   


}

