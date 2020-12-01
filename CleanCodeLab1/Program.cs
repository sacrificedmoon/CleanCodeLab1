using System;

namespace CleanCodeLab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.FizzBuzz(300);
        }

        public void FizzBuzz(int maxNumber)
        {
            
            for (int i = 1; i <= maxNumber; i++)
            {
                if(i == 42)
                {
                    Console.WriteLine("Answer to the Ultimate Question of Life, the Universe, and Everything");
                }
                else if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
