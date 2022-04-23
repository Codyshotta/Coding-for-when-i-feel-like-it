using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class Average
    {
        double CalculateAverage(List<double> numbers)
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
                string input = Console.ReadLine();
                if (input == "stop")
                    break;
                array.Add(double.Parse(input));
            }
            return array;
        }
        public virtual void AllowUserToCalcAVG()
        {
            List<double> array = ReadNumberArray();
            Console.WriteLine(CalculateAverage(array));
        }
    }
}
