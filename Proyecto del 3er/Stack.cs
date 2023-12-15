using System;
using System.Collections;
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
    public partial class Stack : Form
    {

        private StackStatic stackStatic;
        private StackDynamic stackDynamic;

        public Stack()
        {
            InitializeComponent();
            stackStatic = new StackStatic();
            stackDynamic = new StackDynamic();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPopStack_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarStack_Click(object sender, EventArgs e)
        {

        }
        private string ObtenerListaPilaSeleccionada()
        {
            switch (cmbEstructuraStack.Text)
            {
                case "Stack Estatico":
                    return ObtenerListaPila(stackStatic);
                case "Stack Dinamico":
                    return ObtenerListaPila(stackDynamic);
                default:
                    return "Seleccione una estructura de pila.";
            }
        }

        private string ObtenerListaPila(StackStatic pila)
        {
            StringBuilder result = new StringBuilder();
            while (!pila.IsEmpty())
            {
                int valor = pila.Pop();
                result.Insert(0, valor.ToString() + "\n");  // Inserta al principio para mantener el orden correcto
            }
            return result.ToString();
        }

        private string ObtenerListaPila(StackDynamic pila)
        {
            StringBuilder result = new StringBuilder();
            while (!pila.IsEmpty())
            {
                int valor = pila.Pop();
                result.Insert(0, valor.ToString() + "\n");  // Inserta al principio para mantener el orden correcto
            }
            return result.ToString();
        }

        private void InitializeComponent()
        {
            this.btnMostrarStack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbEstructuraStack = new System.Windows.Forms.ComboBox();
            this.txtValorStack = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPopStack = new System.Windows.Forms.Button();
            this.btnAgregarStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarStack
            // 
            this.btnMostrarStack.Location = new System.Drawing.Point(104, 314);
            this.btnMostrarStack.Name = "btnMostrarStack";
            this.btnMostrarStack.Size = new System.Drawing.Size(126, 37);
            this.btnMostrarStack.TabIndex = 31;
            this.btnMostrarStack.Text = "MostrarStack";
            this.btnMostrarStack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(52, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Eligir primero una de las \"colas\" antes de agregar un dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Elige una de las Listas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ingresar dato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 228);
            this.textBox1.TabIndex = 26;
            // 
            // cmbEstructuraStack
            // 
            this.cmbEstructuraStack.FormattingEnabled = true;
            this.cmbEstructuraStack.Items.AddRange(new object[] {
            "Stack Estatico",
            "Stack Dinamico"});
            this.cmbEstructuraStack.Location = new System.Drawing.Point(244, 152);
            this.cmbEstructuraStack.Name = "cmbEstructuraStack";
            this.cmbEstructuraStack.Size = new System.Drawing.Size(172, 28);
            this.cmbEstructuraStack.TabIndex = 25;
            // 
            // txtValorStack
            // 
            this.txtValorStack.Location = new System.Drawing.Point(104, 154);
            this.txtValorStack.Name = "txtValorStack";
            this.txtValorStack.Size = new System.Drawing.Size(126, 26);
            this.txtValorStack.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 43);
            this.button3.TabIndex = 23;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPopStack
            // 
            this.btnPopStack.Location = new System.Drawing.Point(104, 265);
            this.btnPopStack.Name = "btnPopStack";
            this.btnPopStack.Size = new System.Drawing.Size(126, 43);
            this.btnPopStack.TabIndex = 22;
            this.btnPopStack.Text = "Mostrar";
            this.btnPopStack.UseVisualStyleBackColor = true;
            // 
            // btnAgregarStack
            // 
            this.btnAgregarStack.Location = new System.Drawing.Point(104, 219);
            this.btnAgregarStack.Name = "btnAgregarStack";
            this.btnAgregarStack.Size = new System.Drawing.Size(126, 40);
            this.btnAgregarStack.TabIndex = 21;
            this.btnAgregarStack.Text = "Agregar";
            this.btnAgregarStack.UseVisualStyleBackColor = true;
            // 
            // Stack
            // 
            this.ClientSize = new System.Drawing.Size(516, 525);
            this.Controls.Add(this.btnMostrarStack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbEstructuraStack);
            this.Controls.Add(this.txtValorStack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPopStack);
            this.Controls.Add(this.btnAgregarStack);
            this.Name = "Stack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form listas = new Form1();
            this.Hide();
            listas.Show();
        }
    }
}
