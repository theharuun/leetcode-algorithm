using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q145_Postorder_traversel_tree
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


        public static IList<int> InorderTraversal(TreeNode root)
        {     // left -> right -> root
              // once kokukun leftinin degerini sonra kokun sagindakinin degeri ,sonra kokun  degerini yaziyor
            IList<int> list = new List<int>();
            if (root == null) { return null; }

            InorderTraversal(root.left);
            InorderTraversal(root.right);
            Console.WriteLine(root.val);


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
            InorderTraversal(root);
            Console.WriteLine("******************");
            root2.right = new TreeNode(2);
            root2.right.left = new TreeNode(3);
            InorderTraversal(root2);

            Console.ReadLine();


        }
    }
}
