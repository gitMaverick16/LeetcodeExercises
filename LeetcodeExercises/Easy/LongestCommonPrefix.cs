namespace LeetcodeExercises.Easy
{
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPrefix2(string[] strs)
        {
            if (strs.Length == 0) return "";
            var smallWordSize = strs[0].Length;
            for(int i = 0; i < strs.Length -1; i++)
            {
                if (strs[i].Length == 0)
                {
                    smallWordSize = 0;
                    break;
                }
                if (strs[i + 1].Length < smallWordSize)
                {
                    smallWordSize = strs[i + 1].Length;
                }
            }
            var b = true;
            var a = -1;
            for(int i = 0; i< smallWordSize; i++)
            {
                b = true;
                for(int j = 0; j < strs.Length -1; j++)
                {
                    if (!strs[j][i].Equals(strs[j + 1][i]))
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                    a = i;
                else break;
            }
            var fullWord = "";
            if (a == -1) return "";
            for(int i = 0; i <= a; i++)
            {
                fullWord = fullWord + strs[0][i];
            }
            return fullWord;
        }
    }
}
