using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//找第三大元素
//Given a non-empty array of integers, return the third maximum number in this array. 
//If it does not exist, return the maximum number. The time complexity must be in O(n).

namespace LeetCode414
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 2, 6, 4,6,784,4352,342};
            int max = nums[0];
            Array.Sort(nums);
            // Array.Reverse(nums);
            int j = 0;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] != nums[i - 1])
                {
                    j += 1;
                    if (j == 2)
                    {
                        max = nums[i - 1];
                        break;
                    }
                    else
                    {
                        max = nums[i] > nums[i - 1] ? nums[i] : nums[i - 1];
                    }
                }

                //else continue;
            }

            Console.WriteLine(max);//, test[1], test[2], test[3], test[4]);

            Console.ReadKey();
        }
            
    }
    
}


