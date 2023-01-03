using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class WhileLoopRefresh : Test
    {
        public void WhileLoop()
        {
            Console.WriteLine("Enter a value\t");
            valueA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second value\t");
            valueB = Int32.Parse(Console.ReadLine());
            NegativeValidation(valueA, valueB);

            while(valueA > valueB)
            {
                valueB++;
                Console.WriteLine($"Second value is being incrememted by 1 until it equals the First value: "+valueB.ToString());
            }

            Console.WriteLine("For Loop\n");
            for(int i = 20; i >= valueB; valueB++)
            {
                Console.WriteLine(valueB.ToString(), " + 1");
            }

        }
        public void NegativeValidation(int valueA, int valueB)
        {
            if (valueA <= -1)
                throw new ArgumentOutOfRangeException($"Negative Value: " + valueA.ToString(), "Value needs to remain positive");
            if (valueB <= -1)
                throw new ArgumentOutOfRangeException($"Negative Value: " + valueB.ToString(), "Value needs to remain positive");
        }
    }
}
