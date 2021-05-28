using System;

namespace Question4
{
    class Question4
    {
        public static int PivotIndex(int[] nums)
        {
            int len = nums.Length;
            int sum = 0;
            int[] prefix = new int[len];
            for(int i = 0; i < len; i++)
            {
                prefix[i] = sum;
                sum += nums[i];
            }


            for (int i = 0; i < len; i++)
            {
                if (prefix[i] == prefix[len - 1] - prefix[i] - nums[i] + nums[len - 1])
                {
                    return i;
                }
            }

            return -1;
        }

    }
    
    class Program4
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4:");
            int pivot = Question4.PivotIndex(nums);
            if (pivot > 0)
            {
                Console.WriteLine("The Pivot index for the given array is {0}", pivot);
            }
            else
            {
                Console.WriteLine("The given array has no Pivot index");

            }
            Console.WriteLine();

            
        }
    }
}
