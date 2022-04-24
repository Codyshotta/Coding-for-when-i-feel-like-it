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
            Average average = new Average();
            //Total total = new Total();
            average.AllowUserToInputNumbers();
        }
    }
}
