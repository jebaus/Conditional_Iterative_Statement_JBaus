using System.Linq.Expressions;

namespace Conditional_Iterative_Statement_JBaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while(true)
            {
                try
                {
                    //Show the user a prompt they can input a number into
                    Console.WriteLine("Enter a number between 1 and 100: ");
                    //Establish a variable that lets the user input a number
                    input = int.Parse(Console.ReadLine());

                    //Implement if statement to catch any inputs less than 1 or greater than 100
                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                
                }
                catch
                {
                    Console.WriteLine("Please input a valid number.");
                }
               
            }

            while (true)
            {
                try
                {
                    //Specify whether you want the user to choose an even or odd sequence
                    Console.Write("Specify the series type: Even or Odd ");
                    //Establish the string that lets the user choose even or odd
                    series = Console.ReadLine();

                    //Implement if statement to catch any inputs that aren't even or odd
                    if (series == "Even" || series == "even" || series == "odd" || series == "Odd")
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please input a valid string statement.");
                }
               
            }

            //Pathway if user chooses odd
            if (series == "Odd" || series == "odd")
            {
                Console.Write("You have selected " + series + "series. The numbers between 0 and " + input + "are: ");
                for (int i = 1; i < input; i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            //Pathway if user chooses even
            if (series == "Even" || series == "even")
            {
                Console.Write("You have selected " + series + "series. The numbers between 0 and " + input + " are: ");
                for (int i = 0; i < input; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}