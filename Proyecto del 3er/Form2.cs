using System.Windows.Forms;

namespace Proyecto_del_3er
{
    public partial class Form2 : Form
    {
        private BinaryTree binaryTree;

        public Form2()
        {
            InitializeComponent();

            binaryTree = new BinaryTree();
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                switch (cmbEstructuras.Text)
                {
                    case "Árbol Binario":
                        txtMostrar.Text = "Árbol Binario (In-Order Traversal):\n" + binaryTree.InOrderTraversal();
                        break;
                    default:
                        break;
                }
                txtValor.Clear();
                MessageBox.Show("Elemento agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnMostrar_Click(object sender, System.EventArgs e)
        {
            switch (cmbEstructuras.Text)
            {
                case "Árbol Binario":
                    txtMostrar.Text = "Árbol Binario (In-Order Traversal):\n" + binaryTree.InOrderTraversal();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form listas = new Form1();
            this.Hide();
            listas.Show();
        }
    }

}

public class BinaryTree
{
    private class TreeNode
    {
        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    private TreeNode root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int data)
    {
        root = InsertRec(root, data);
    }

    private TreeNode InsertRec(TreeNode root, int data)
    {
        if (root == null)
        {
            root = new TreeNode(data);
            return root;
        }

        if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }

        return root;
    }

    public string InOrderTraversal()
    {
        return InOrderTraversal(root);
    }

    private string InOrderTraversal(TreeNode root)
    {
        string result = "";
        if (root != null)
        {
            result += InOrderTraversal(root.Left);
            result += root.Data + " ";
            result += InOrderTraversal(root.Right);
        }
        return result;
    }
}
