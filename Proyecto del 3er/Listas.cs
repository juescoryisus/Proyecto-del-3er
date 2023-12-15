using EstructurasDatosFormulario;
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
    public partial class Listas : Form
    {
        private SimpleList simpleList;
        private DoubleList doubleList;
        private CircularList circularList;
        private CircularDoublyLinkedList circularDoublyLinkedList;


        public Listas()
        {
            InitializeComponent();
            simpleList = new SimpleList();
            doubleList = new DoubleList();
            circularList = new CircularList();
            circularDoublyLinkedList = new CircularDoublyLinkedList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form listas = new Form1();
            this.Hide();
            listas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                switch (cmbEstructuras.Text)
                {
                    case "Lista Simple":
                        simpleList.AgregarElemento(valor);
                        break;
                    case "Lista Doble":
                        doubleList.InsertarNodo(valor);
                        break;
                    case "Lista Circular":
                        circularList.InsertarNodo(valor);
                        break;
                    case "Lista Doble Circular":
                        circularDoublyLinkedList.InsertarNodo(valor);
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

        private void button2_Click(object sender, EventArgs e)
        {
            switch (cmbEstructuras.Text)
            {
                case "Lista Simple":
                    txtMostrar.Text = "Lista Simple:\n" + simpleList.MostrarLista();
                    break;
                case "Lista Doble":
                    txtMostrar.Text = "Lista Doble:\n" + doubleList.DesplegarLista();
                    break;
                case "Lista Circular":
                    txtMostrar.Text = "Lista Circular:\n" + circularList.DesplegarLista();
                    break;
                case "Lista Doble Circular":
                    txtMostrar.Text = "Lista Doble Circular:\n" + circularDoublyLinkedList.DesplegarLista();
                    break;
                default:
                    break;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form listas = new Form1();
            this.Hide();
            listas.Show();
        }
    }
}

