namespace Proyecto_MatematicasDiscretas
{
    partial class Form_Conjuntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Conjuntos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ConjuntoA = new System.Windows.Forms.TextBox();
            this.txt_ConjuntoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Union = new System.Windows.Forms.Button();
            this.txt_Resultados = new System.Windows.Forms.TextBox();
            this.Btn_Interseccion = new System.Windows.Forms.Button();
            this.Btn_DiffSimetrica = new System.Windows.Forms.Button();
            this.Btn_BDiffA = new System.Windows.Forms.Button();
            this.Btn_ADiffB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Diagrama_Veen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Diagrama_Veen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 100);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(530, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONJUNTOS";
            // 
            // txt_ConjuntoA
            // 
            this.txt_ConjuntoA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConjuntoA.Location = new System.Drawing.Point(52, 145);
            this.txt_ConjuntoA.Multiline = true;
            this.txt_ConjuntoA.Name = "txt_ConjuntoA";
            this.txt_ConjuntoA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ConjuntoA.Size = new System.Drawing.Size(209, 190);
            this.txt_ConjuntoA.TabIndex = 10;
            this.txt_ConjuntoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ConjuntoB
            // 
            this.txt_ConjuntoB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConjuntoB.Location = new System.Drawing.Point(641, 145);
            this.txt_ConjuntoB.Multiline = true;
            this.txt_ConjuntoB.Name = "txt_ConjuntoB";
            this.txt_ConjuntoB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ConjuntoB.Size = new System.Drawing.Size(209, 190);
            this.txt_ConjuntoB.TabIndex = 12;
            this.txt_ConjuntoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "DIAGRAMA DE VEEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Conjunto A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(687, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Conjunto B";
            // 
            // Btn_Union
            // 
            this.Btn_Union.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Union.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Union.Location = new System.Drawing.Point(52, 380);
            this.Btn_Union.Name = "Btn_Union";
            this.Btn_Union.Size = new System.Drawing.Size(165, 34);
            this.Btn_Union.TabIndex = 18;
            this.Btn_Union.Text = "Union";
            this.Btn_Union.UseVisualStyleBackColor = true;
            this.Btn_Union.Click += new System.EventHandler(this.Btn_Union_Click);
            // 
            // txt_Resultados
            // 
            this.txt_Resultados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultados.Location = new System.Drawing.Point(410, 380);
            this.txt_Resultados.Multiline = true;
            this.txt_Resultados.Name = "txt_Resultados";
            this.txt_Resultados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Resultados.Size = new System.Drawing.Size(440, 110);
            this.txt_Resultados.TabIndex = 21;
            this.txt_Resultados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Interseccion
            // 
            this.Btn_Interseccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Interseccion.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Interseccion.Location = new System.Drawing.Point(52, 420);
            this.Btn_Interseccion.Name = "Btn_Interseccion";
            this.Btn_Interseccion.Size = new System.Drawing.Size(165, 34);
            this.Btn_Interseccion.TabIndex = 22;
            this.Btn_Interseccion.Text = "Interseccion";
            this.Btn_Interseccion.UseVisualStyleBackColor = true;
            this.Btn_Interseccion.Click += new System.EventHandler(this.Btn_Interseccion_Click);
            // 
            // Btn_DiffSimetrica
            // 
            this.Btn_DiffSimetrica.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DiffSimetrica.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_DiffSimetrica.Location = new System.Drawing.Point(52, 460);
            this.Btn_DiffSimetrica.Name = "Btn_DiffSimetrica";
            this.Btn_DiffSimetrica.Size = new System.Drawing.Size(165, 34);
            this.Btn_DiffSimetrica.TabIndex = 23;
            this.Btn_DiffSimetrica.Text = "Diferencia Simetrica";
            this.Btn_DiffSimetrica.UseVisualStyleBackColor = true;
            this.Btn_DiffSimetrica.Click += new System.EventHandler(this.Btn_DiffSimetrica_Click);
            // 
            // Btn_BDiffA
            // 
            this.Btn_BDiffA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BDiffA.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_BDiffA.Location = new System.Drawing.Point(223, 447);
            this.Btn_BDiffA.Name = "Btn_BDiffA";
            this.Btn_BDiffA.Size = new System.Drawing.Size(165, 34);
            this.Btn_BDiffA.TabIndex = 24;
            this.Btn_BDiffA.Text = "B Diferencia A";
            this.Btn_BDiffA.UseVisualStyleBackColor = true;
            this.Btn_BDiffA.Click += new System.EventHandler(this.Btn_BDiffA_Click);
            // 
            // Btn_ADiffB
            // 
            this.Btn_ADiffB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ADiffB.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_ADiffB.Location = new System.Drawing.Point(223, 407);
            this.Btn_ADiffB.Name = "Btn_ADiffB";
            this.Btn_ADiffB.Size = new System.Drawing.Size(165, 34);
            this.Btn_ADiffB.TabIndex = 25;
            this.Btn_ADiffB.Text = "A Diferencia B";
            this.Btn_ADiffB.UseVisualStyleBackColor = true;
            this.Btn_ADiffB.Click += new System.EventHandler(this.Btn_ADiffB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(406, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Visualizacion ";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Limpiar.Location = new System.Drawing.Point(586, 355);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(264, 20);
            this.Btn_Limpiar.TabIndex = 27;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(155, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Operaciones";
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.BackgroundImage = global::Proyecto_MatematicasDiscretas.Properties.Resources.volver;
            this.Btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Volver.FlatAppearance.BorderSize = 0;
            this.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volver.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Volver.Location = new System.Drawing.Point(12, 8);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(50, 40);
            this.Btn_Volver.TabIndex = 31;
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.BackgroundImage")));
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Minimizar.Location = new System.Drawing.Point(795, 8);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(50, 40);
            this.Btn_Minimizar.TabIndex = 30;
            this.Btn_Minimizar.UseVisualStyleBackColor = true;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackgroundImage = global::Proyecto_MatematicasDiscretas.Properties.Resources.cerrar_simbolo_de_boton_circular;
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Cerrar.Location = new System.Drawing.Point(850, 8);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(50, 40);
            this.Btn_Cerrar.TabIndex = 29;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Diagrama_Veen
            // 
            this.Diagrama_Veen.BackColor = System.Drawing.Color.White;
            this.Diagrama_Veen.Image = global::Proyecto_MatematicasDiscretas.Properties.Resources.Normal;
            this.Diagrama_Veen.Location = new System.Drawing.Point(300, 105);
            this.Diagrama_Veen.Name = "Diagrama_Veen";
            this.Diagrama_Veen.Size = new System.Drawing.Size(300, 230);
            this.Diagrama_Veen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Diagrama_Veen.TabIndex = 11;
            this.Diagrama_Veen.TabStop = false;
            // 
            // Form_Conjuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.Btn_Minimizar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_ADiffB);
            this.Controls.Add(this.Btn_BDiffA);
            this.Controls.Add(this.Btn_DiffSimetrica);
            this.Controls.Add(this.Btn_Interseccion);
            this.Controls.Add(this.txt_Resultados);
            this.Controls.Add(this.Btn_Union);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ConjuntoB);
            this.Controls.Add(this.Diagrama_Veen);
            this.Controls.Add(this.txt_ConjuntoA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Conjuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Diagrama_Veen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ConjuntoA;
        private System.Windows.Forms.PictureBox Diagrama_Veen;
        private System.Windows.Forms.TextBox txt_ConjuntoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Union;
        private System.Windows.Forms.TextBox txt_Resultados;
        private System.Windows.Forms.Button Btn_Interseccion;
        private System.Windows.Forms.Button Btn_DiffSimetrica;
        private System.Windows.Forms.Button Btn_BDiffA;
        private System.Windows.Forms.Button Btn_ADiffB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Volver;
    }
}