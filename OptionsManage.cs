using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class OptionsManage
    {
        public static string[] OptionsList =
        {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "dr - Divide Remainder",
            "ex - Exit"
        };
        public static void DivideRemainder(double a, double b)
        {
            Console.WriteLine($"{a} % {b} = {a % b}");
        }

    }
}
