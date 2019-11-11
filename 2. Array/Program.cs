using System;

namespace _2._Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4] { 1, 2, 3, 4 };
            int[] nums1 = new int[] { 1, 2, 3, 4 };
            int[] nums2 = new[] { 1, 2, 3, 4 };
            int[] nums3 = { 1, 2, 3, 4 };
            int[] nums4 = new int[4];
            nums4[0] = 1;
            nums4[1] = 2;
            nums4[2] = 3;
            nums4[3] = 4;
            for (int g = 0; g < nums4.Length; g++)
            {
                nums4[g] = nums4[g] * 2;
                Console.WriteLine(nums4[g]);
            }
            for (int j = 0; j<nums4.Length; j++)
            {
                Console.WriteLine(nums4[j]);
            }
            foreach(int i in nums4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(nums4[3]);
            int[,] nums22;
            int[,] nums23 = new int[2, 3];
            int[,] nums24 = new int[2, 3] { { 0, 1, 2 },{ 3, 4, 5 } };
            int[,] nums25 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums26 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums27 = { { 0, 1, 2 }, { 3, 4, 5 } };
        }
    }
}
