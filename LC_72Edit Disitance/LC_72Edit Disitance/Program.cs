//Given two words word1 and word2, find the minimum number of steps required to convert word1 to word2. (each operation is counted as 1 step.)

//You have the following 3 operations permitted on a word:

//a) Insert a character
//b) Delete a character
//c) Replace a character

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LC_72Edit_Disitance
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abc";
            string s1 = "dcfabc";
            int l_s = s.Length;
            int l_s1 = s1.Length;
            int delcost = 1;//删除花费
            int incost = 1;//插入花费
            int subcost = 1;//修改花费
            int[,] dp = new int[l_s + 1,l_s1 + 1];
            for (int i = 0; i < l_s + 1; i++)
            {
                dp[i, 0] = i;
            }
            for (int i = 0; i < l_s1 + 1; i++)
            {
                dp[0, i] = i;
            }
            for (int i = 1; i < l_s + 1; i++)
            {
                for (int j = 1; j < l_s1 + 1; j++)
                {
                    if (s[i - 1] == s1[j - 1])
                        dp[i, j] = Math.Min(Math.Min(dp[i - 1, j] + incost, dp[i, j - 1] + delcost), dp[i - 1, j - 1]);
                    else
                        dp[i, j] = Math.Min(Math.Min(dp[i - 1, j] + incost, dp[i, j - 1] + delcost), dp[i - 1, j - 1] + subcost);
                }
            }
            //Console.WriteLine(l_s);
            //Console.WriteLine(l_s1);
           // Stack st = new Stack();
            //int.MinValue 
           // Console.WriteLine(k);
             Console.WriteLine(dp[l_s,l_s1]);
            Console.ReadKey();
        }
    }
}
