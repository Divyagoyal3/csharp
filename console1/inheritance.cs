/* Inheritance*/


using System;
class Inherit 
{
    
    class Student1
    {
        public string s_name1;
        public int s_id;
         
        //method 
        public void print()
        {
            Console.WriteLine("Name of First Student is:" +s_name1);
            Console.WriteLine("Id of First Student is:" +s_id);
        }
    }    
    class Student2:Student1
    {
        public string s_name2;
        public int roll_no;
        
        //method
        public void print1()
        {
            Console.WriteLine("Name of  Second Student is :" +s_name2);
            Console.WriteLine("Roll no of Second student is :" +roll_no);
            base.s_name1="Amit";
        }
        
    }   
    
    class Mca :Student2
    {
        public int records;
         
         //method
         public  void record_mca()
         {
             records=200;
             Console.WriteLine(" Total numbers of Records in Mca Chandigarh is:"+records);
         }
    }
            
        
      static void Main(string[] args) 
      {
         Mca s2 = new Mca();
         s2.s_name1="Divya";
         s2.s_id=101;
         s2.print();
         
         Console.WriteLine();
         s2.s_name2="Queen";
         s2.roll_no=102;
         s2.print1();
         
         Console.WriteLine();
         s2.record_mca();
         
         Console.WriteLine(" New  name is:" +s2.s_name1);
      }
}
