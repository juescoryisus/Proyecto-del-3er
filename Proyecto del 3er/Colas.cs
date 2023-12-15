using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_del_3er
{
    public partial class Colas : Form
    {

        private Queue<int> cola;
        private Queue<int> prioridadQueue;
        private Queue<int> circularQueue;

        public Colas()
        {
            InitializeComponent();

           
            cola = new Queue<int>();
            prioridadQueue = new Queue<int>();
            circularQueue = new Queue<int>();
        }

 

        private string DesplegarCola()
        {
            // Convierte la cola en una cadena para mostrarla
            return string.Join(", ", cola.ToArray());
        }

        private string DesplegarPrioridadQueue()
        {
            // Convierte la PrioridadQueue en una cadena para mostrarla
            return string.Join(", ", prioridadQueue.ToArray());
        }
        private string DesplegarCircularQueue()
        {
            return string.Join(",", circularQueue.ToArray());
        }

        private void InitializeComponent()
        {
            this.cmbEstructuraColas = new System.Windows.Forms.ComboBox();
            this.btnAgreagrColas = new System.Windows.Forms.Button();
            this.btnMostrarColas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtValorColas = new System.Windows.Forms.TextBox();
            this.txtMostrarColas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEstructuraColas
            // 
            this.cmbEstructuraColas.FormattingEnabled = true;
            this.cmbEstructuraColas.Items.AddRange(new object[] {
            "Cola",
            "PrioridadQueue",
            "CircularQueue"});
            this.cmbEstructuraColas.Location = new System.Drawing.Point(220, 62);
            this.cmbEstructuraColas.Name = "cmbEstructuraColas";
            this.cmbEstructuraColas.Size = new System.Drawing.Size(152, 28);
            this.cmbEstructuraColas.TabIndex = 0;
            // 
            // btnAgreagrColas
            // 
            this.btnAgreagrColas.Location = new System.Drawing.Point(65, 99);
            this.btnAgreagrColas.Name = "btnAgreagrColas";
            this.btnAgreagrColas.Size = new System.Drawing.Size(92, 47);
            this.btnAgreagrColas.TabIndex = 1;
            this.btnAgreagrColas.Text = "Agregar";
            this.btnAgreagrColas.UseVisualStyleBackColor = true;
            this.btnAgreagrColas.Click += new System.EventHandler(this.btnAgreagrColas_Click);
            // 
            // btnMostrarColas
            // 
            this.btnMostrarColas.Location = new System.Drawing.Point(65, 152);
            this.btnMostrarColas.Name = "btnMostrarColas";
            this.btnMostrarColas.Size = new System.Drawing.Size(92, 51);
            this.btnMostrarColas.TabIndex = 2;
            this.btnMostrarColas.Text = "Mostrar";
            this.btnMostrarColas.UseVisualStyleBackColor = true;
            this.btnMostrarColas.Click += new System.EventHandler(this.btnMostrarColas_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtValorColas
            // 
            this.txtValorColas.Location = new System.Drawing.Point(65, 62);
            this.txtValorColas.Name = "txtValorColas";
            this.txtValorColas.Size = new System.Drawing.Size(126, 26);
            this.txtValorColas.TabIndex = 4;
            // 
            // txtMostrarColas
            // 
            this.txtMostrarColas.Location = new System.Drawing.Point(220, 109);
            this.txtMostrarColas.Multiline = true;
            this.txtMostrarColas.Name = "txtMostrarColas";
            this.txtMostrarColas.Size = new System.Drawing.Size(126, 140);
            this.txtMostrarColas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(61, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Elejir una de las siguientes Colas en el Listbox";
            // 
            // Colas
            // 
            this.ClientSize = new System.Drawing.Size(448, 305);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMostrarColas);
            this.Controls.Add(this.txtValorColas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMostrarColas);
            this.Controls.Add(this.btnAgreagrColas);
            this.Controls.Add(this.cmbEstructuraColas);
            this.Name = "Colas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        private void btnAgreagrColas_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValorColas.Text, out int valor))
            {
                switch (cmbEstructuraColas.Text)
                {
                    case "Cola":
                        cola.Enqueue(valor);
                        break;
                    case "PrioridadQueue":
                        prioridadQueue.Enqueue(valor);
                        break;
                    case "CircularQueue":
                        circularQueue.Enqueue(valor);
                        break;
                    default:
                        break;
                }
                txtValorColas.Clear();
                MessageBox.Show("Elemento agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void btnMostrarColas_Click_1(object sender, EventArgs e)
        {
            switch (cmbEstructuraColas.Text)
            {
                case "Cola":
                    txtMostrarColas.Text = "Cola:\n" + DesplegarCola();
                    break;
                case "PrioridadQueue":
                    txtMostrarColas.Text = "PrioridadQueue:\n" + DesplegarPrioridadQueue();
                    break;
                case "CircularQueue":
                    txtMostrarColas.Text = "CircularQueue:\n" + DesplegarCircularQueue();
                    break;
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form listas = new Form1();
            this.Hide();
            listas.Show();
        }
    }
}