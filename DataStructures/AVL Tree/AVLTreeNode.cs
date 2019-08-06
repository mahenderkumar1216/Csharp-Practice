using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.AVL_Tree
{
    public class AVLTreeNode<TNode> : IComparable<TNode> where TNode : IComparable
    {



        AVLTree<TNode> _tree;

        public AVLTreeNode(TNode value, AVLTreeNode<TNode> parent, AVLTree<TNode> tree)
        {
            Value = value;
            Parent = parent;
            _tree = tree;
        }

        AVLTreeNode<TNode> _left;
        public AVLTreeNode<TNode> Left
        {
            get
            {
                return _left;
            }
            internal set
            {
                _left = value;
                if (_left != null)
                {
                    _left.Parent = this;
                }
            }
        }

        AVLTreeNode<TNode> _right;
        public AVLTreeNode<TNode> Right
        {
            get
            {
                return _right;
            }
            internal set
            {
                _right = value;
                if (_right != null)
                {
                    _right.Parent = this;
                }
            }
        }
        public AVLTreeNode<TNode> Parent { get; internal set; }
        public TNode Value { get; internal set; }

        //Support Properties and Method
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int MaxChildHeight(AVLTreeNode<TNode> node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }
            return 0;
        }

        private int LeftHeight
        {
            get
            {
                return MaxChildHeight(Left);
            }
        }

        private int RightHeight
        {
            get
            {
                return MaxChildHeight(Right);
            }
        }

        private int BalanceFactor
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }
        private TreeState State
        {
            get
            {
                if (LeftHeight - RightHeight > 1)
                {
                    return TreeState.LeftHeavy;
                }

                if (RightHeight - LeftHeight > 1)
                {
                    return TreeState.RightHeavy;
                }

                return TreeState.Balanced;
            }
        }

        internal void Balance()
        {
            if (State == TreeState.RightHeavy)
            {
                if (Right != null && Right.BalanceFactor < 0)
                {
                    LeftRightRotation();
                }
                else
                {
                    LeftRotation();
                }
            }
            else if (State == TreeState.LeftHeavy)
            {
                if (Left != null && Left.BalanceFactor > 0)
                {
                    RightLeftRotation();
                }
                else
                {
                    RightRotation();
                }
            }
        }

        //Balacing Methods
        private void ReplaceRoot(AVLTreeNode<TNode> newRoot)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Left == this)
                {
                    this.Parent.Left = newRoot;
                }
                else if (this.Parent.Right == this)
                {
                    this.Parent.Right = newRoot;
                }
            }
            else
            {
                _tree._head = newRoot;
            }

            newRoot.Parent = this.Parent;
            this.Parent = newRoot;
        }

        private void LeftRotation()
        {
            //     a
            //      \
            //       b
            //        \
            //         c
            //
            // becomes
            //       b
            //      / \
            //     a   c

            AVLTreeNode<TNode> newRoot = Right;

            // replace the current root with the new root
            ReplaceRoot(newRoot);

            // take ownership of right's left child as right (now parent)
            Right = newRoot.Left;

            // the new root takes this as it's left
            newRoot.Left = this;
        }

        private void RightRotation()
        {
            //     c (this)
            //    /
            //   b
            //  /
            // a
            //
            // becomes
            //       b
            //      / \
            //     a   c

            AVLTreeNode<TNode> newRoot = Left;

            // replace the current root with the new root
            ReplaceRoot(newRoot);

            // take ownership of left's right child as left (now parent)
            Left = newRoot.Right;

            // the new root takes this as it's right
            newRoot.Right = this;
        }

        private void LeftRightRotation()
        {
            Right.RightRotation();
            LeftRotation();
        }

        private void RightLeftRotation()
        {
            Left.LeftRotation();
            RightRotation();
        }
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
    }

    public enum TreeState
    {
        Balanced,
        LeftHeavy,
        RightHeavy,
    }
}
