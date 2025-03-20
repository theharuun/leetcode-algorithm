using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q101_Symmetric_Tree
{
    internal class Program
    {
        
          // Definition for a binary tree node.
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
            private bool IsMirror(TreeNode left, TreeNode right)
            {
                if (left == null && right == null) return true; // her iki kısımda nullsa true dön
                if (left == null || right == null) return false;// biri null biri null değilse false dön

                return (left.val == right.val) // iç içe fonksiyon olarak sonsuza kadar götürcez ve solun solu sağın sagın / sagın solu solun sagına esitse ve true donerse butun degerler icin kontrol basarılıdır.
                       && IsMirror(left.left, right.right)
                       && IsMirror(left.right, right.left);
            }

            public bool IsSymmetric(TreeNode root)
            {
                if (root == null) return true;
                return IsMirror(root.left, root.right);
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            // [1, 2, 2, 3, 4, 3, 4] dizisini aşağıdaki gibi ağaç yapısına çeviriyoruz:  -- > False dönmeli 
            /*
                 1
              2     2
            3  4   3  4
             */
            TreeNode root1 = new TreeNode(1,
                new TreeNode(2, new TreeNode(3), new TreeNode(4)),
                new TreeNode(2, new TreeNode(3), new TreeNode(4))
            );
            // [1, 2, 2, 3, 4, 4, 3] dizisini aşağıdaki gibi ağaç yapısına çeviriyoruz:
            /*
                   1
                2     2
              3  4   4  3
            */
            TreeNode root = new TreeNode(1,
                new TreeNode(2, new TreeNode(3), new TreeNode(4)),
                new TreeNode(2, new TreeNode(4), new TreeNode(3))
            );


            bool result =s.IsSymmetric(root);

            Console.WriteLine("result is " + result);
            Console.ReadLine();
        }
    }
}
