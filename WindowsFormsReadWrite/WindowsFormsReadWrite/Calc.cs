using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsReadWrite
{
    class Calc
    {
        public static string Tocalc(string item)
        {
            string operand = ""; double ans = 0;
            string first = item.Split('+', '^', '-', '*', '%', '/').First();
            string second = item.Split('+', '^', '-', '*', '%', '/').Last();
            double First = 0.0; double Second = 0.0;
            Double.TryParse(first, out First);
            Double.TryParse(second, out Second);

            if (item.Contains("+"))
            {
                operand = "+";
                ans = First + Second;
            }

            else if (item.Contains("-"))
            {
                operand = "-";
                ans = First - Second;
            }
            else if (item.Contains("*"))
            {
                operand = "*";
                ans = First * Second;
            }

            else if (item.Contains("%"))
            {
                operand = "%";
                ans = First % Second;
            }

            else if (item.Contains("/"))
            {
                operand = "/";
                ans = First / Second;
            }
            else if (item.Contains("^"))
            {
                operand = "^";
                ans = Math.Pow(First, Second);
            }
            return (First + operand + Second + " = " + Math.Round(ans, 2));
        }
    }
}
