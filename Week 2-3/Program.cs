using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int F, C; // int for celcius and fehernite
            Console.WriteLine("Welcome to Temperature Converter");// Calcucaltor
            Console.WriteLine("Enter the temperature: "); // enter the tempature
            F = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(C = (F-32) * 5/9); // get total for Celcius
            Console.WriteLine($"{F} Fernite to {C} Celsius"); // read result

            Console.ReadLine(); // readline
        }
    }
}
