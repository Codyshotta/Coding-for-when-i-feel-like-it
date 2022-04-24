using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    internal class Total : Math2
    {
        public override double Calculate(List<double> numbers)
        {
            double total = 0;
            foreach (double number in numbers)
                total += number;
            return total;
        }
    }
}
