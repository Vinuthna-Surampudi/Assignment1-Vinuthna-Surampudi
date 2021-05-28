using System;

namespace Question_3
{
    class Question3
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            int ans = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            int gp = Question3.NumIdenticalPairs(nums);
            Console.WriteLine("Q3:");
            Console.WriteLine("The number of IdenticalPairs in the array are {0}:", gp);
        }
    }
}
