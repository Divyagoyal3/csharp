using System ;
class first
{
    
   public void firstfun1()
   {
      Console.Title="Third Day";
      Console.ForegroundColor=ConsoleColor.DarkBlue;
      
      Console.WriteLine("Day 3 Learning with C#");
       int a =10, b=20;
       int c=a+b;
       Console.WriteLine(c);
       Console.ReadLine();
   }
    public void inputs()
    {
        // Type your username and press enter
        Console.WriteLine("Enter username");
      
       // Create a string variable and get user input from the keyboard and store it in the variable
       string userName = Console.ReadLine();

       // Print the value of the variable (userName), which will display the input value
       Console.WriteLine("Username is: " + userName);
       
       Console.ReadLine();
    }
    public void conversions()
    {
        //Multiplication of two numbers
int num1;
int num2;
Console.WriteLine("Input a Number");

//type conversion
num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Second Number:");

num2=Convert.ToInt32(Console.ReadLine());

int result= num1 * num2;

Console.WriteLine("Multiplication of Two number is:{0}",result);

Console.ReadLine();
}
    public void conditions()
    {
        Console.WriteLine("Welcome ! tickets are 5$, Please insert cash:");

        int cash =Convert.ToInt32(Console.ReadLine());

        if(cash<=5)
        {
            Console.WriteLine("that's not enough");
        }
        else if(cash ==5){
            Console.WriteLine("Here is your Ticket.");
        }
        else
        {
            int change = cash - 5;
            Console.WriteLine("Here is Your Ticket" + change + "Dollar in charge");
        }
        Console.ReadLine();
    }

    public void looping()
    {
        Console.WriteLine("How many ccol numbers do you want :");

        int count=Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <=count; i++)
        {
            double result=Math.Pow(2,i);
            Console.WriteLine(result);
        }
        // Wait before closing
        Console.ReadLine();
    }
     public void looks()
     {
         Random numberGen= new Random();

         int roll=0;
         int attempts =0;

         Console.WriteLine("Press enter to roll the die.");

         while(roll!=6)
         {
             Console.ReadKey();
             roll=numberGen.Next(1,7);
             Console.WriteLine("You rolled:" +roll);
             attempts++;
         }

         Console.WriteLine("It Took yoy "+attempts + "attempts to roll six");
         //wait before closing
         Console.ReadLine();
     }

}
