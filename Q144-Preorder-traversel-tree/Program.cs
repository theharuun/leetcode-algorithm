using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q144_Preorder_traversel_tree
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }


        public static IList<int> PreorderTraversal(TreeNode root)
        {   // root -> left -> right   
            // once kokuk degerini sonra kokun solunu sonra kokun sagindakinin degerini yaziyor
            IList<int> list = new List<int>();
            if (root == null) { return null; }

            Console.WriteLine(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);


            return list;
        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            TreeNode root2 = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            PreorderTraversal(root);
            Console.WriteLine("******************");
            root2.right = new TreeNode(2);
            root2.right.left = new TreeNode(3);
            PreorderTraversal(root2);

            Console.ReadLine();

        }
    }
}
