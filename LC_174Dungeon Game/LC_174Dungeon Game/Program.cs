using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///174 Dungeon game
///The demons had captured the princess (P) and imprisoned her in the bottom-right corner of a dungeon.
///The dungeon consists of M x N rooms laid out in a 2D grid. Our valiant knight (K) was initially positioned 
///in the top-left room and must fight his way through the dungeon to rescue the princess.
///The knight has an initial health point represented by a positive integer.
///If at any point his health point drops to 0 or below, he dies immediately.

///Some of the rooms are guarded by demons, so the knight loses health (negative integers) upon entering these rooms; 
///other rooms are either empty (0's) or contain magic orbs that increase the knight's health (positive integers).

///In order to reach the princess as quickly as possible, 
///the knight decides to move only rightward or downward in each step.
///DP解法
namespace LC_174Dungeon_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dungeon = new int[,] { { 2,-3,3}, { -5,-10,1 } , { 1,-3,-5 }};
            int M = dungeon.GetLength(0) - 1;//行数 
            int N = dungeon.GetLength(1) - 1;//列数
            int[,] dp = new int[M + 1, N + 1];
            if (dungeon[M, N] <= 0)
                dp[M, N] = Math.Abs(dungeon[M, N]) + 1;
            else dp[M, N] = 1;
            for (int i = N - 1; i >= 0; i--)
            {
                if (dungeon[M, i] >= dp[M, i + 1])
                    dp[M, i] = 1;
                else
                    dp[M, i] = dp[M, i + 1] - dungeon[M, i];

            }
            for (int i = M - 1; i >= 0; i--)
            {
                if (dungeon[i, N] >= dp[i + 1, N])
                    dp[i, N] = 1;
                else
                    dp[i, N] = dp[i + 1, N] - dungeon[i, N];

            }
            int temp_right = 1;
            int temp_down = 1;
            for (int j = N - 1;j >= 0; j--)
                for(int i = M - 1;i>=0;i--)
                {
                    //右
                    if (dungeon[i, j] >= dp[i, j + 1])
                        temp_right = 1;
                    else
                        temp_right = dp[i, j + 1] - dungeon[i, j];

                    //下
                    if (dungeon[i, j] >= dp[i +1, j])
                        temp_down = 1;
                    else
                        temp_down = dp[i+1, j] - dungeon[i, j];
                    
                    dp[i, j] = Math.Min(temp_down, temp_right);
                    
                }
            //return (dp[0,0]);
            Console.ReadKey();
        }
    }
}
