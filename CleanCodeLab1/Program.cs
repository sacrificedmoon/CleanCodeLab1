using System;

namespace CleanCodeLab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.UserInput();
        }

        public void UserInput()
        {
            Console.WriteLine("Ange ett heltal mellan 1 och 300: ");
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput< 1 || userInput > 300)
                {
                    UserInput();
                }
                else 
                {
                    for (int i = 0; i <= userInput; i++)
                    {
                        Console.WriteLine(FizzBuzz(i));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                UserInput();
            }
            
        } 

        public string FizzBuzz(int number)
        {
            string output;
            
            if(number == 42)
            {
                output = "Answer to the Ultimate Question of Life, the Universe, and Everything";
            }
            else if(number % 3 == 0 && number % 5 == 0)
            {
                output = "Fizzbuzz";
            }
            else if(number % 3 == 0)
            {
                output = "Fizz";
            }
            else if(number % 5 == 0)
            {
                output = "Buzz";
            }
            else
            {
                output = number.ToString();
            }
            return output;
        }
    }
}
