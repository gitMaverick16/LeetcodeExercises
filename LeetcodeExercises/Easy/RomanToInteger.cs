using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercises.Easy
{
    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var arr = s.ToCharArray();
            var result = 0;
            var INegative = new char[] { 'V', 'X'};
            var XNegative = new char[] { 'L', 'C'};
            var CNegative = new char[] { 'D', 'M'};
            for(int i=0; i<arr.Length; i++)
            {
                var isPenultimate = i + 1 >= arr.Length;
                switch (arr[i])
                {
                    case 'I':
                        if (!isPenultimate && INegative.Contains(arr[i + 1])) result--;
                        else result++;
                        break;
                    case 'V': result = result + 5; break;
                    case 'X':
                        if (!isPenultimate && XNegative.Contains(arr[i + 1])) result = result - 10;
                        else result = result + 10; 
                        break;
                    case 'L': result = result + 50; break;
                    case 'C':
                        if (!isPenultimate && CNegative.Contains(arr[i+1])) result = result - 100;
                        else result = result + 100; break;
                    case 'D': result = result + 500; break;
                    case 'M': result = result + 1000; break;
                }
            }
            return result;
        }
    }
}
