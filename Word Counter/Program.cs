using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(args[0]);
            Console.WriteLine(reader.ReadToEnd().Split(' ').ToList().FindAll((s => s == args[1])).Count);
            Console.ReadLine();
        }
    }
}
