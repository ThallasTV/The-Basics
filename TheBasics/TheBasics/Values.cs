using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes;


public class IfStatement : Test
{
    public void If()
    {
        Console.WriteLine("Enter a value\t");
        valueA = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second value\t");
        valueB = Int32.Parse(Console.ReadLine());

        if (valueA < valueB)
            Console.WriteLine(valueA.ToString(), " is smaller than " + valueB);
        else
        {
            result = valueA + valueB;
            Console.WriteLine($"First value is larger than the first. Total of both values:  " + result);
        }  
    }
}


