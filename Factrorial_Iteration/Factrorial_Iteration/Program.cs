using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factrorial_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter the Number to find the factorial in itteration method");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = number; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();
        }
    }
}
