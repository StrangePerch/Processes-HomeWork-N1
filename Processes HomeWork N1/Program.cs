using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processes_HomeWork_N1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input ('num' 'action' 'num'): ");
            var input = Console.ReadLine();
            ProcessStartInfo info1 = new ProcessStartInfo();
            info1.Arguments = input;
            info1.FileName = "..\\..\\..\\Calc\\bin\\Debug\\Calc.exe";
            Process process1 = Process.Start(info1);

            
            Console.Write("Path: ");
            //var path = Console.ReadLine();
            var path = "..\\..\\..\\Test.txt";
            Console.Write("Word: ");
            //var word = Console.ReadLine();
            var word = "a";

            ProcessStartInfo info2 = new ProcessStartInfo();
            info2.Arguments = path + ' ' + word;
            info2.FileName = "..\\..\\..\\Word Counter\\bin\\Debug\\Word Counter.exe";
            Process process2 = Process.Start(info2);
            

        }
    }
}
