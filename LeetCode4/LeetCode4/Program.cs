using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

// Median of Two Sorted Arrays
// There are two sorted arrays nums1 and nums2 of size m and n respectively.
// Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

namespace LeetCode4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList List;
            ArrayList List2;
            int[] nums1 = new int[] {2};
            int[] nums2 = new int[] {1,3};
            int N = nums1.Length + nums2.Length;
            double[] values1 = new double[nums1.Length];
            double[] values2 = new double[nums2.Length];
            for (int k = 0;k < nums2.Length; k++){
                values2[k] = nums2[k];
            }
            for (int k = 0; k < nums1.Length; k++)
            {
                values1[k] = nums1[k];
            }
            double result;
            if (nums1.Length >= nums2.Length)
            {
                List = new ArrayList(values1);
                List2 = new ArrayList(values2);
            }
            else
            {
                List = new ArrayList(values2);
                List2 = new ArrayList(values1);
            }

            int i = 0;
            int j = 0;
            if (List2.Count == 0)
            {
                if (N % 2 == 0)
                {
                    //if (List2[N / 2 - 1] == List2[N / 2])
                    // {
                    result = ((((double)List[N / 2 - 1] + (double)List[N / 2])) / 2.00);
                    // }
                    // else result = (int)List2[N / 2 - 1];
                    Console.WriteLine (result);
                }
                else
                {
                    if (List.Count == 1) Console.WriteLine ((double)List[0]);
                    Console.WriteLine ((double)List[(N - 1) / 2]);
                }
            }
            else if ((double)List[List.Count - 1] <= (double)List2[0])
            {
                for (int k = 0; k < List2.Count; k++ )
                {
                    List.Add(List2[k]);
                }
                if (N % 2 == 0)
                {   
                    result = ((((double)List[N / 2 - 1] + (double)List[N / 2])) / 2.00);

                    Console.WriteLine(result);
                }
                else {
                    Console.WriteLine((double)List[(N - 1) / 2]);
                }
            }
            else if ((double)List[0] >= (double)List2[List2.Count - 1])
            {
                for (int k = List2.Count - 1; k >= 0; k--)
                {
                    List.Insert(0,List2[k]);
                }
                if (N % 2 == 0)
                {
                    result = ((((double)List[N / 2 - 1] + (double)List[N / 2])) / 2.00);
                }
                else
                {
                    Console.WriteLine((double)List[(N - 1) / 2]);
                }
            }
            else if(N % 2 == 0){
                while (i <= N / 2){               
                    while(j < nums2.Length){
                        if ((double)List2[j] > (double)List[i])
                        {
                            break;
                        }

                        else
                        {
                            List.Insert(i, List2[j]);
                            j += 1;
                            break;
                        }
                    }
                    i += 1;
                }
                result = ((((double)List[N / 2 - 1] + (double)List[N / 2])) / 2.00);
                Console.WriteLine(result);
            }
            else{
                 while (i <= (N - 1) / 2){
                     while (j < nums2.Length)
                     {
                         if ((double)List2[j] > (double)List[i])
                         {
                             break;
                         }
                         else
                         {
                             List.Insert(i, List2[j]);
                             j += 1;
                             break;
                         }
                     }
                     i += 1;
                }
                 Console.WriteLine ((double)List[(N - 1) / 2]);
            }
            Console.ReadKey();
            }
    }
}
