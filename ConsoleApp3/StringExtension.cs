using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class StringExtension
    {
        public static bool IsValid(this string sor) => (!sor.StartsWith(')') && !sor.EndsWith('(') && sor.Count(x => x == ')') == sor.Count(x => x == '('));
    }
}
