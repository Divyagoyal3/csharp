
using System;
class HelloWorld {
  static void Main() {
   
   meetalien();
   
   Console.WriteLine("------------");
   
   meetalien();
  
  }
   static void meetalien()
  {
     Random numgen = new Random();
     
     string name="X--" +numgen.Next(10,9999);
     int age=numgen.Next(10,500);
     
     Console.WriteLine("Hi , I'm"+name);
     Console.WriteLine("I m " + age + " year's old ." );
     Console.WriteLine("Oh , I m  an alien .");
  }

}
