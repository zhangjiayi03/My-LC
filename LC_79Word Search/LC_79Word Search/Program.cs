using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Given a 2D board and a word, find if the word exists in the grid.

//The word can be constructed from letters of sequentially adjacent cell, 
//where "adjacent" cells are those horizontally or vertically neighboring. 
//The same letter cell may not be used more than once.
namespace LC_79Word_Search
{
    class Program
    {
        //public static bool result;
        static void Main(string[] args)
        {
            //["CAA","AAA","BCD"]
            char[,] board = new char[,] { {'C'} };
            string word = "CA";
            for (int i = 0; i < board.GetLength(0); i++)
                for (int j = 0; j < board.GetLength(1); j++)
                    if (Find(board, word, 0, i, j)) Console.WriteLine(true);// true;
            Console.WriteLine(false);
            Console.ReadKey();
        }
        private static bool Find(char[,] board, string word, int position, int x, int y)
        {
            char temp;// 存储
            if (position == word.Length) return true;
            if (x < 0 || x >= board.GetLength(0) || y < 0 || y >= board.GetLength(1)) return false;
            if (board[x, y] == word[position++])//比较之后进行右移
            {
                temp = board[x, y];
                board[x, y] = '#';
                bool result = Find(board, word, position, x - 1, y) || Find(board, word, position, x + 1, y) || Find(board, word, position, x, y - 1) || Find(board, word, position, x, y + 1);
                board[x, y] = temp;
                return result;
            }
            return false;
        }
    }
   }