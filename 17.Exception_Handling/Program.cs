using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your First Number ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Your Second Number ");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your first number divided by your second number is ");
                Console.WriteLine(number1 / number2);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            
        }

        
    }
}
