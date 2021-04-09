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
            bool result = true; 
            TreeNode root = new TreeNode(1);
            // Left
            root.left = new TreeNode(1);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(1);
            // Right
            root.right = new TreeNode(1);
            root.right.left = new TreeNode(3);
            root.right.right = new TreeNode(1);
            
            Check(root, ref result);
            Console.WriteLine(result);
        }

        public static void Check(TreeNode root, ref bool result){

            int val = root.val;

            if(root.right != null){
                if(root.right.val != val){
                    result = false;
                    return;
                } 
                Check(root.right, ref result);
            }
            
            if(root.left != null){
                if(root.left.val != val){
                    result = false;
                    return;
                } 
                Check(root.left, ref result);
            }
        }

    }
}
