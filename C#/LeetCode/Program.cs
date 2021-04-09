using System;
using LeetCode.DataStuctures;
using LeetCode.SortingAlgos;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            // Left
            root.left = new TreeNode(2);
            root.left.right = new TreeNode(5);
            // Right
            root.right = new TreeNode(3);
            
            IList<string> res  = _0257_BinaryTreePaths.BinaryTreePaths(root);

            foreach(string str in res){
                Console.Write(str);
            }
        }

    }
}
