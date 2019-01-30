using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void SumNumbers1To100()
        {
            var total = 0;
            var counter = 1;
            while (counter <= 100)
            {
                total += counter;
                counter += 1;
            }
            Console.WriteLine($"The sum of the numbers 1 to 100 is {total}");
        }
        static void MultiplyNumbers1To25()
        {
            var total = 1;
            var counter = 1;
            while (counter <= 25)
            {
                total = total * counter;
                counter += + 1;
            }
            Console.WriteLine($"Multiplying the numbers form 1 to 25 totals {total}");
        }
        static void UsedForToSumNumber()
        {
            var total = 0;
            for(var idx = 0; idx < 10; idx++)
            {
                total += idx;
            }
            Console.WriteLine($"Total is {total}");
        }
        static void Main(string[] args)
            {
                UsedForToSumNumber();
                SumNumbers1To100();
                MultiplyNumbers1To25();
            }   
    }
}
