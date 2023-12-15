//using System;
//using System.Windows.Forms;

//namespace BinaryTreeForm
//{
//    public partial class Form1 : Form
//    {
//        private BinaryTree binaryTree;

//        public Form1()
//        {
//            InitializeComponent();
//            binaryTree = new BinaryTree();
//        }

//        private void btnAgregar_Click(object sender, EventArgs e)
//        {
//            if (int.TryParse(txtValor.Text, out int valor))
//            {
//                binaryTree.Insert(valor);
//                txtValor.Clear();
//                MessageBox.Show("Elemento agregado al árbol binario exitosamente.");
//            }
//            else
//            {
//                MessageBox.Show("Ingrese un valor numérico válido.");
//            }
//        }

//        private void btnMostrar_Click(object sender, EventArgs e)
//        {
//            txtMostrar.Text = "Árbol Binario (In-Order Traversal):\n" + binaryTree.InOrderTraversal();
//        }
//    }

//    public class BinaryTree
//    {
//        private class TreeNode
//        {
//            public int Data { get; set; }
//            public TreeNode Left { get; set; }
//            public TreeNode Right { get; set; }

//            public TreeNode(int data)
//            {
//                Data = data;
//                Left = null;
//                Right = null;
//            }
//        }

//        private TreeNode root;

//        public BinaryTree()
//        {
//            root = null;
//        }

//        public void Insert(int data)
//        {
//            root = InsertRec(root, data);
//        }

//        private TreeNode InsertRec(TreeNode root, int data)
//        {
//            if (root == null)
//            {
//                root = new TreeNode(data);
//                return root;
//            }

//            if (data < root.Data)
//            {
//                root.Left = InsertRec(root.Left, data);
//            }
//            else if (data > root.Data)
//            {
//                root.Right = InsertRec(root.Right, data);
//            }

//            return root;
//        }

//        public string InOrderTraversal()
//        {
//            return InOrderTraversal(root);
//        }

//        private string InOrderTraversal(TreeNode root)
//        {
//            if (root == null)
//            {
//                return "";
//            }

//            string result = InOrderTraversal(root.Left);
//            result += root.Data + " ";
//            result += InOrderTraversal(root.Right);

//            return result;
//        }
//    }
//}
