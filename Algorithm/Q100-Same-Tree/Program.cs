using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q100_Same_Tree
{
    internal class Program
    {

         public class TreeNode 
        {
             public int val;
             public TreeNode left;
             public TreeNode right;
             public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                 this.val = val;
                 this.left = left;
                 this.right = right;
             }
         }
 
        public class Solution
        {
            public bool IsSameTree(TreeNode p, TreeNode q)
            {
                if (p == null && q == null)
                {
                    return true;
                }

                if (p == null || q == null)
                {
                    return false;
                }

                if (p.val != q.val)
                {
                    return false;
                }

                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);    
            root.right = new TreeNode(3);

            TreeNode root2 = new TreeNode(1);
            root2.left = new TreeNode(2);
            root2.right = new TreeNode(3);
            s.IsSameTree(root, root2);

            Console.ReadLine();
            
        }
    }
}
