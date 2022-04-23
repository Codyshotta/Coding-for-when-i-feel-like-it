using System;
using System.Linq;
using System.Collections.Generic;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.Start();
        }
        void Start()
        {
            List<double> array = ReadNumberArray();
            Console.WriteLine(Average(array));
        }
        double Average(List<double> numbers)
        {
            double total = 0;
            foreach (double number in numbers)
                total += number;
            return total / numbers.Count;
        }
        List<double> ReadNumberArray()
        {
            List<double> array = new List<double>();
            while (true)
            {
                Console.Write("please enter needed numbers if all numbers have been added type stop: ");
                string number = Console.ReadLine();
                if (number == "stop")
                    break;
                array.Add(double.Parse(number));
            }
            return array;
        }
    }
}
