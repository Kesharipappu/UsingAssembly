using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
namespace UsingAssembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCalc calc = new MyCalc();
            Console.WriteLine(calc.Add(700,300));
            Console.WriteLine(calc.Multiply(15,30));
        }
    }
}
