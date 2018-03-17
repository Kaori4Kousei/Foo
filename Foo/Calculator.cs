using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Foo
{
    public static class Calculator
    {
        public static int Add(int x, int y) => x + y;
        public static int Eval(string inputText) => (int)new DataTable().Compute(inputText, null);

        public static void ParsesString(string inputText)
        {
            foreach (var match in Regex.Matches(inputText, @"([*+/\-)(])|([0-9]+)"))
            {
                Console.WriteLine(match.ToString());
            }
        }

    }
}
