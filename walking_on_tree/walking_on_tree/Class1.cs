using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walking_on_tree
{
    internal class Node
    {
        public Node next;
        public Node prev;
        public int data;
        public Node(int number)
        {
            this.data = number;
        }
    }
    internal class List
    {
        public Node head;
        public Node tail;
        public int count = 0;
        public void addFirst(int number)
        {
            Node add = new Node(number);
            if (head == null)
            {
                head = tail = null;
            }
            else
            {
                add.next = head;
                head.prev = add;
                head = add;
            }
            count++;
        }
        internal class NodeT
        {
            public NodeT parent;
            public NodeT left;
            public NodeT right;
            public int data;
            public NodeT(int number)
            {
                data = number;
            }
        }
        internal class BST
        {
            public NodeT root;
            public void add(int number)
            {
                if(root == null)
                {
                    root = new NodeT(number);
                }
                else
                {
                    addLeftOrRight(root, number);
                }
            }
            private void addLeftOrRight(NodeT node, int number)
            {
                if(number < node.data)
                {
                    if(node.left == null)
                    {
                        node.left = new NodeT(number);
                        node.left.parent = node;
                    }
                    else
                    {
                        addLeftOrRight(node.left, number);
                    }
                }
                else
                {
                    if(node.right == null)
                    {
                        node.right = new NodeT(number);
                        node.right.parent = node;
                    }
                    else
                    {
                        addLeftOrRight(node.right, number);
                    }
                }
            }
            public void remove(int number)
            {
                NodeT node = find(root, number);
                if(node == null)
                {
                    return;
                }
                if(node.left == null && node.right == null)
                {
                    if(node == root)
                    {
                        root = null;
                    }
                    else
                    {
                        if(node.parent.left == node)
                        {
                            node.parent.left = null;
                        }
                        else
                        {
                            node.parent.right = null;
                        }
                    }
                }
                else if(node.left == null || node.right == null)
                {
                    NodeT child;
                    if(node.left != null)
                    {
                        child = node.left;
                    }
                    else
                    {
                        child = node.right;
                    }
                    if(node == root)
                    {
                        root = child;
                    }
                    else
                    {
                        if(node.parent.left == node)
                        {
                            node.parent.left = child;
                        }
                        else
                        {
                            node.parent.right = child;
                        }
                    }
                    child.parent = node.parent;
                }
                else
                {
                    NodeT temp = findMin(node.right);
                    node.data = temp.data;
                    remove(temp.data);
                }
            }
            private NodeT findMin(NodeT node)
            {
                while(node.left != null)
                {
                    node = node.left;
                }
                return node;
            }
            private NodeT find(NodeT node, int number)
            {
                if(node == null || node.data == number)
                {
                    return node;
                }
                if(number < node.data)
                {
                    return find(node.left, number);
                }
                else
                {
                    return find(node.right, number);
                }
            }
        }
    }
}