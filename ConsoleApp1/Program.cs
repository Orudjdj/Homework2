using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 214;
                int remain =0;
            while (number != 0)
            {
                remain += number % 10;
                number = number / 10;
            }
            Console.WriteLine(remain);  
        }

        
       
    }
}
