
namespace parcial2
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSubir = new System.Windows.Forms.Button();
            this.textBoxcontenido = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonParcial2 = new System.Windows.Forms.Button();
            this.buttonParcial3 = new System.Windows.Forms.Button();
            this.buttonParcial1 = new System.Windows.Forms.Button();
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(502, 232);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(130, 23);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Arreglo";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(378, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(118, 147);
            this.listBox1.TabIndex = 1;
            // 
            // buttonSubir
            // 
            this.buttonSubir.Location = new System.Drawing.Point(12, 170);
            this.buttonSubir.Name = "buttonSubir";
            this.buttonSubir.Size = new System.Drawing.Size(135, 23);
            this.buttonSubir.TabIndex = 2;
            this.buttonSubir.Text = "Subir archivo";
            this.buttonSubir.UseVisualStyleBackColor = true;
            this.buttonSubir.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxcontenido
            // 
            this.textBoxcontenido.Location = new System.Drawing.Point(12, 22);
            this.textBoxcontenido.Multiline = true;
            this.textBoxcontenido.Name = "textBoxcontenido";
            this.textBoxcontenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxcontenido.Size = new System.Drawing.Size(269, 142);
            this.textBoxcontenido.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(96, 423);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(146, 23);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Lista de Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonParcial2
            // 
            this.buttonParcial2.Location = new System.Drawing.Point(502, 180);
            this.buttonParcial2.Name = "buttonParcial2";
            this.buttonParcial2.Size = new System.Drawing.Size(130, 23);
            this.buttonParcial2.TabIndex = 5;
            this.buttonParcial2.Text = "Promedio Parcial2";
            this.buttonParcial2.UseVisualStyleBackColor = true;
            this.buttonParcial2.Click += new System.EventHandler(this.buttonP2_Click);
            // 
            // buttonParcial3
            // 
            this.buttonParcial3.Location = new System.Drawing.Point(638, 180);
            this.buttonParcial3.Name = "buttonParcial3";
            this.buttonParcial3.Size = new System.Drawing.Size(130, 23);
            this.buttonParcial3.TabIndex = 6;
            this.buttonParcial3.Text = "Promedio Parcial3";
            this.buttonParcial3.UseVisualStyleBackColor = true;
            this.buttonParcial3.Click += new System.EventHandler(this.buttonParcial3_Click);
            // 
            // buttonParcial1
            // 
            this.buttonParcial1.Location = new System.Drawing.Point(378, 180);
            this.buttonParcial1.Name = "buttonParcial1";
            this.buttonParcial1.Size = new System.Drawing.Size(118, 23);
            this.buttonParcial1.TabIndex = 7;
            this.buttonParcial1.Text = "Promedio Parcial1";
            this.buttonParcial1.UseVisualStyleBackColor = true;
            this.buttonParcial1.Click += new System.EventHandler(this.buttonParcial1_Click);
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.Location = new System.Drawing.Point(12, 221);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(294, 199);
            this.listBoxNombres.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(502, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(130, 147);
            this.listBox2.TabIndex = 9;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(638, 22);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(129, 147);
            this.listBox3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista de estudiantes y notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Promedio general de cada parcial";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(162, 170);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(118, 23);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.Text = "Eliminar archivo ";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBoxNombres);
            this.Controls.Add(this.buttonParcial1);
            this.Controls.Add(this.buttonParcial3);
            this.Controls.Add(this.buttonParcial2);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxcontenido);
            this.Controls.Add(this.buttonSubir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSubir;
        private System.Windows.Forms.TextBox textBoxcontenido;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonParcial2;
        private System.Windows.Forms.Button buttonParcial3;
        private System.Windows.Forms.Button buttonParcial1;
        private System.Windows.Forms.ListBox listBoxNombres;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEliminar;
    }
}

