// See https://aka.ms/new-console-template for more information
using LeetcodeExercises.Easy;

Console.WriteLine("Hello, World!");

var result = LongestCommonPrefix.LongestCommonPrefix2(new string[] { "abbb", "a", "accc", "aa" });

public static class Solution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {

        int index = m + n - 1;  
        while (n > 0)
        {
            if (m > 0 && nums1[m - 1] > nums2[n - 1])
            {
                nums1[index] = nums1[m - 1];
                m--;
            }
            else
            {
                nums1[index] = nums2[n - 1];
                n--;
            }
            index--;
        }
    }
}