using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///The string "PAYPALISHIRING" is written in a zigzag pattern 
///on a given number of rows like this
///P   A   H   N
///A P L S I I G
///Y   I   R
///And then read line by line: "PAHNAPLSIIGYIR"
///(you may want to display this pattern in a fixed font for better legibility)
namespace LC_6ZigZag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "PAYPALISHIRING";
            StringBuilder s1 = new StringBuilder();
            int numRows = 5;
            //if (numRows <= 0)
            //    //return "";
            //if (numRows == 1 || numRows >= s.Length)
            //    //return s;  
            for (int i = 0; i < s.Length && i < numRows; i++)
            {
                //start是每行第一个数的地址
                int start = i;
                s1.Append(s[start]);
                for (int j = 1; start < s.Length; j++)
                {
                    if (i == 0 || i == numRows - 1)
                        start += 2 * numRows - 2;
                    else
                    {
                        // 奇数列
                        if (j % 2 == 1)
                        {
                            start += 2 * (numRows - i - 1);
                        }
                        //  偶数列
                        else
                        {
                            start += 2 * i;
                        }
                    }
                    if (start < s.Length)
                        s1.Append(s[start]);
                }
                
            }
            Console.WriteLine(s1.ToString());
            //Console.WriteLine(s.Length/numRows);
            //Console.WriteLine(s1[0]);
            Console.ReadKey();
        }
    }
}
