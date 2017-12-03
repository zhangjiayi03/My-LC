using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Array;

namespace LeetCode414
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 2, 6, 4 };
            //Array.Sort(test);
            int[] nums_order = new int[nums.Length];
            nums.CopyTo(nums_order, 0);
            Array.Sort(nums);
            int head = nums.Length;
            int tail = -1;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] != nums_order[i])
                {
                    head = Math.Min(head, i);
                }
                if (nums[nums.Length - i - 1] != nums_order[nums.Length - i - 1])
                {
                    tail = Math.Max(tail, nums.Length - i - 1);
                }
            }

            //return (tail - head + 1);
            //for (int i = 0; i < 5; i++)
           // {
            Console.Write(tail - head + 1);//, test[1], test[2], test[3], test[4]);
            //}
            Console.ReadKey();
        }
            
    }
    
}


