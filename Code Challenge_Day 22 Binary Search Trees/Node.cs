using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenge_Day_22_Binary_Search_Trees
{
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
