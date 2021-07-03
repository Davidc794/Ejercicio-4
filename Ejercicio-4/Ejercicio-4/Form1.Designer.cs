namespace Ejercicio_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.EdadtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.Ordenarbutton = new System.Windows.Forms.Button();
            this.OrdenarLixbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(80, 22);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox.TabIndex = 0;
            // 
            // EdadtextBox
            // 
            this.EdadtextBox.Location = new System.Drawing.Point(80, 69);
            this.EdadtextBox.Name = "EdadtextBox";
            this.EdadtextBox.Size = new System.Drawing.Size(100, 20);
            this.EdadtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad :";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(220, 28);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(101, 45);
            this.Agregarbutton.TabIndex = 4;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Location = new System.Drawing.Point(237, 119);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(75, 23);
            this.Ejecutarbutton.TabIndex = 6;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // Ordenarbutton
            // 
            this.Ordenarbutton.Location = new System.Drawing.Point(237, 175);
            this.Ordenarbutton.Name = "Ordenarbutton";
            this.Ordenarbutton.Size = new System.Drawing.Size(75, 23);
            this.Ordenarbutton.TabIndex = 7;
            this.Ordenarbutton.Text = "Ordenar";
            this.Ordenarbutton.UseVisualStyleBackColor = true;
            this.Ordenarbutton.Click += new System.EventHandler(this.Ordenarbutton_Click);
            // 
            // OrdenarLixbox
            // 
            this.OrdenarLixbox.FormattingEnabled = true;
            this.OrdenarLixbox.Location = new System.Drawing.Point(80, 157);
            this.OrdenarLixbox.Name = "OrdenarLixbox";
            this.OrdenarLixbox.Size = new System.Drawing.Size(120, 95);
            this.OrdenarLixbox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 275);
            this.Controls.Add(this.OrdenarLixbox);
            this.Controls.Add(this.Ordenarbutton);
            this.Controls.Add(this.Ejecutarbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdadtextBox);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox EdadtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.Button Ordenarbutton;
        private System.Windows.Forms.ListBox OrdenarLixbox;
    }
}

