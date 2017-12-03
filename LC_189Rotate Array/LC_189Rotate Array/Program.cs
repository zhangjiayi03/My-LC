using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

//Rotate an array of n elements to the right by k steps.

//For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] 
//is rotated to [5,6,7,1,2,3,4].

//Note:
//Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
namespace LC_189Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {   
            //public ArrayList(int);
            int k = 1;          
            int[] nums = new int[] {1,2,3};
            if (k > nums.Length) k = k - nums.Length;
            /// method 1
            //int[] locate = new int[nums.Length];
            //int[] nums_copy = new int[nums.Length];
            //for(int i = 0;i < nums.Length; i ++)
            //{
            //    locate[i] = i;
            //    nums_copy[i] = nums[i];
            //}
            
            //for (int i = 0; i < k; i++)
            //{
            //    locate[i] += nums.Length - k;
            //}
            //for (int i = k; i < nums.Length; i++)
            //{
            //    locate[i] = locate[i] - k;
            //}
            //for(int i = 0;i < nums.Length ;i ++)
            //    nums[i] = nums_copy[locate[i]];

            ///method 2
            //ArrayList arr = new ArrayList(nums);
            //int[] arr_rotate = new int[k];
            //ArrayList rotate = new ArrayList(arr_rotate);

            //for (int i = 0; i < k; i++)
            //{
            //    rotate[i] = arr[i + nums.Length - k];

            //}
            //arr.RemoveRange(nums.Length - k, k);
            //arr.InsertRange(0,rotate);
            //nums = (int[])arr.ToArray(typeof(Int32));//arraylist转为int[]
            ///method 3 直接修改赋值
            int[] copy = nums.Clone() as int[];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[(i + k) % nums.Length] = copy[i];
            }
            Console.ReadKey();
        }
    }
}
