using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercises.Easy
{
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            while(s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
            {
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            return s.Equals("");
        }
    }
}
