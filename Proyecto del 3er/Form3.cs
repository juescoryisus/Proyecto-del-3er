using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_del_3er
{
    public partial class Form3 : Form
    {
        private DirectedGraph directedGraph;

        public Form3()
        {
            InitializeComponent();
            directedGraph = new DirectedGraph();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int valor))
            {
                GraphNode newNode = new GraphNode(valor);
                directedGraph.AddNode(newNode);
                textBox1.Clear();
                MessageBox.Show("Nodo agregado al grafo dirigido exitosamente.");
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int desde) && int.TryParse(textBox2.Text, out int hasta))
            {
                GraphNode nodeDesde = new GraphNode(desde);
                GraphNode nodeHasta = new GraphNode(hasta);
                directedGraph.AddEdge(nodeDesde, nodeHasta);
                MessageBox.Show("Arista agregada al grafo dirigido exitosamente.");
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para los nodos.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form listas = new Form1();
            this.Hide();
            listas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
    public class GraphNode
    {
        public int Value { get; set; }

        public GraphNode(int value)
        {
            Value = value;
        }
    }

    // Clase para el grafo dirigido
    public class DirectedGraph
    {
        private Dictionary<GraphNode, List<GraphNode>> adjacencyList;

        public DirectedGraph()
        {
            adjacencyList = new Dictionary<GraphNode, List<GraphNode>>();
        }

        public void AddNode(GraphNode node)
        {
            if (!adjacencyList.ContainsKey(node))
            {
                adjacencyList[node] = new List<GraphNode>();
            }
        }

        public void AddEdge(GraphNode from, GraphNode to)
        {
            AddNode(from);
            AddNode(to);

            adjacencyList[from].Add(to);
        }
    }

    // Clase para el grafo no dirigido
    public class UndirectedGraph
    {
        private Dictionary<GraphNode, List<GraphNode>> adjacencyList;

        public UndirectedGraph()
        {
            adjacencyList = new Dictionary<GraphNode, List<GraphNode>>();
        }

        public void AddNode(GraphNode node)
        {
            if (!adjacencyList.ContainsKey(node))
            {
                adjacencyList[node] = new List<GraphNode>();
            }
        }

        public void AddEdge(GraphNode node1, GraphNode node2)
        {
            AddNode(node1);
            AddNode(node2);

            adjacencyList[node1].Add(node2);
            adjacencyList[node2].Add(node1);
        }
    }
}