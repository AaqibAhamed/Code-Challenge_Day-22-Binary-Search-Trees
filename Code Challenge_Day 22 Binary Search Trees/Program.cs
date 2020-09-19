using System;

namespace Code_Challenge_Day_22_Binary_Search_Trees
{
    class Program
    {
        static int GetHeight(Node root)
        {
            return (root == null) ? -1 : Math.Max(1+ GetHeight(root.left), 1+GetHeight(root.right));

        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = GetHeight(root);
            Console.WriteLine(height);

        }
    }
}
