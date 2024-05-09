namespace LeetcodeExercises.Easy
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            var xtext = x.ToString();
            for(int i = 0; i< xtext.Length; i++)
            {
                if (xtext[i] != xtext[xtext.Length-(i+1)])
                    return false;
            }
            return true;
        }
    }
}
