using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    abstract class Math2
    {
        public abstract double Calculate (List<double> numbers);

        //    double total = 0;
        //    foreach (double number in numbers)
        //        total += number;
        //    return total / numbers.Count;
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
        public void AllowUserToInputNumbers()
        {
            List<double> array = ReadNumberArray();
            if (Choose() == true)
                Console.WriteLine(CalculateTotal(array));
            else Console.WriteLine(CalculateAverage(array));
        }
        bool Choose()
        {
            Console.Write("do you want the total or average? 0 for total 1 for average: ");
            string input = Console.ReadLine();
            if (input == "0")
                return true;
            return false;
        }
    }
}
