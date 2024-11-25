using System.ComponentModel;

namespace bst_23_10
{
    internal class Tree
    {
        public NodeT root;

        public Tree()
        {
            root = null;
        }

        public void Add(int data)
        {
            NodeT child = new NodeT(data);
            if (root == null)
            {
                root = child;
            }
            else
            {
                NodeT current = root;
                NodeT parent = null;
                while (current != null)
                {
                    parent = current;
                    if (data < parent.data)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
                if (data < parent.data)
                {
                    parent.left = child;
                }
                else
                {
                    parent.right = child;
                }
                child.parent = parent;
            }
        }

        public NodeT FindNode(int data)
        {
            NodeT current = root;
            while (current != null)
            {
                if (data < current.data)
                {
                    current = current.left;
                }
                else if (data > current.data)
                {
                    current = current.right;
                }
                else
                    return current;
            }
            return null;
        }

        private void RemoveElementWithZeroChild(NodeT nodeToRemove)
        {
            if (this.root == nodeToRemove)
            {
                this.root = null;
            }
            else
            {
                if (nodeToRemove.parent.left == nodeToRemove)
                {
                    nodeToRemove.parent.left = null;
                }
                else if (nodeToRemove.parent.right == nodeToRemove)
                {
                    nodeToRemove.parent.right = null;
                }
                nodeToRemove.parent = null;
            }
            nodeToRemove.parent = null;
            nodeToRemove.left = null;
            nodeToRemove.right = null;

        }

        private void RemoveElementWithOneChild(NodeT nodeToRemove)
        {
            NodeT child = (nodeToRemove.left != null) ? nodeToRemove.left : nodeToRemove.right;
            NodeT parent = nodeToRemove.parent;
            if (parent != null)
            {
                if (parent.left == nodeToRemove)
                {
                    parent.left = child;
                }
                else
                {
                    parent.right = child;
                }
            }
            else
            {
                root = child;
            }
            if (child != null)
            {
                child.parent = parent;
            }
            nodeToRemove.left = null;
            nodeToRemove.right = null;
            nodeToRemove.parent = null;
        }

        private NodeT FindMin(NodeT node)
        {
            NodeT result = node;
            while (result.left != null)
            {
                result = result.left;
            }
            return result;
        }

        public void Remove(int data)
        {
            NodeT nodeToRemove = FindNode(data);
            if (nodeToRemove == null)
            {
                return;
            }
            switch (nodeToRemove.GetLiczbaDzieci())
            {
                case 0:
                    RemoveElementWithZeroChild(nodeToRemove);
                    break;
                case 1:
                    RemoveElementWithOneChild(nodeToRemove);
                    break;
                case 2:
                    NodeT kandydat = FindMin(nodeToRemove.right);
                    nodeToRemove.data = kandydat.data;
                    if (kandydat.parent.left == kandydat)
                    {
                        kandydat.parent.left = kandydat.right;
                    }
                    else
                    {
                        kandydat.parent.right = kandydat.right;
                    }
                    if (kandydat.right != null)
                    {
                        kandydat.right.parent = kandydat.parent;
                    }
                    break;
                default:
                    break;
            }
        }

        public void InOrder(NodeT nodet)
        {
            if (nodet == null) return;
            InOrder(nodet.left);
            Console.Write(nodet.data + " -> ");
            InOrder(nodet.right);
        }

        public void PreOrder(NodeT nodet)
        {
            if (nodet == null) return;
            Console.Write(nodet.data + " -> ");
            PreOrder(nodet.left);
            PreOrder(nodet.right);
        }

        public void PostOrder(NodeT nodet)
        {
            if (nodet == null) return;
            PostOrder(nodet.left);
            PostOrder(nodet.right);
            Console.Write(nodet.data + " -> ");
        }

        public void PrintTree(NodeT node, string prefix = "", bool isLeft = true)
        {
            if (node == null)
            {
                return;
            }

            if (node.right != null)
            {
                PrintTree(node.right, prefix + (isLeft ? "│   " : "    "), false);
            }

            Console.WriteLine(prefix + (isLeft ? "└── " : "┌── ") + node.data);

            if (node.left != null)
            {
                PrintTree(node.left, prefix + (isLeft ? "    " : "│   "), true);
            }
        }
    }
}
