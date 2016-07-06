using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string random = " I love Devascloud";
            string[] names = new string[5] { "black", "blue", "red", "white", "yellow" };
            foreach (char e in String.Join(" ", names))
            {

                Console.WriteLine(e);
            }
        }
    }
}
