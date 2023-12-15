namespace Proyecto_del_3er
{
    partial class Listas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbEstructuras = new System.Windows.Forms.ComboBox();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(49, 126);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(126, 26);
            this.txtValor.TabIndex = 3;
            // 
            // cmbEstructuras
            // 
            this.cmbEstructuras.FormattingEnabled = true;
            this.cmbEstructuras.Items.AddRange(new object[] {
            "Simple List",
            "Doubl List",
            "Circular List",
            "Doubly Circular Linked List"});
            this.cmbEstructuras.Location = new System.Drawing.Point(189, 124);
            this.cmbEstructuras.Name = "cmbEstructuras";
            this.cmbEstructuras.Size = new System.Drawing.Size(172, 28);
            this.cmbEstructuras.TabIndex = 4;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(189, 191);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(172, 228);
            this.txtMostrar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresar dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elige una de las Listas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(-3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eligir primero una de las listas antes de agregar un dato";
            // 
            // Listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.cmbEstructuras);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Listas";
            this.Text = "Listas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbEstructuras;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}