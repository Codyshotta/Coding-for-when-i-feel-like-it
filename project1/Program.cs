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
            try
            {
                Console.Write("Please enter if you want to calculate the total or average. ");
                string input = Console.ReadLine().ToLower();
                Math2 math2 = CheckInput(input);
                math2.AllowUserToInputNumbers();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        private Math2 CheckInput(string input)
        {
            if (input == "average" || input == "total")
            {
                switch (input)
                {
                    case "average":
                        return new Average();
                    case "total":
                        return new Total();
                }
            }
            else
                throw new Exception("invalid value entered.");
            return new Average();
        }
    }
}
