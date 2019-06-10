using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int result = calc.Add(3, 5);

            if (result != 8)
                throw new InvalidOperationException();
                
        }
    }
}
