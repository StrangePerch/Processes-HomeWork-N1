using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(args[0]);
            int b = int.Parse(args[2]);
            switch (args[1])
            {
                case "+": Console.WriteLine(a + b); break;
                case "-": Console.WriteLine(a - b); break;
                case "/": Console.WriteLine(a / b); break;
                case "*": Console.WriteLine(a * b); break;
            }
            Console.ReadLine();
        }
    }
}
