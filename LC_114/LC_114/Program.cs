using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LC_114
{
    public class TreeNode
    {
        int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {   
            TreeNode root= new TreeNode(10);
            TreeNode head = new TreeNode(-1);
            head.right = root;
            TreeNode node = head;

            while (node.right != null)
            {
                node = node.right;
                if (node.left != null)
                {
                    TreeNode end = node.left;
                    while (end.right != null)
                    {
                        end = end.right;
                    }

                    TreeNode tmp = node.right;

                    node.right = node.left;
                    node.left = null;
                    end.right = tmp;
                }
                head.right = null; // 去掉引用方便垃圾回收
            }
            Console.ReadKey();
        }
    }
}
