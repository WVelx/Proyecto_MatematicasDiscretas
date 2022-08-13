namespace Proyecto_MatematicasDiscretas
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_TablasVerdad = new System.Windows.Forms.Button();
            this.Btn_Conjuntos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo_Universidad = new System.Windows.Forms.PictureBox();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Universidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 150);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Creado por:\r\nJohan Orlando Daza Amaya\r\nChristian Andrés Acosta Cárdenas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(151, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATEMATICAS DISCRETAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(742, 62);
            this.label3.TabIndex = 1;
            this.label3.Text = "CONJUNTOS E INFERENCIA";
            // 
            // Btn_TablasVerdad
            // 
            this.Btn_TablasVerdad.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TablasVerdad.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_TablasVerdad.Location = new System.Drawing.Point(71, 304);
            this.Btn_TablasVerdad.Name = "Btn_TablasVerdad";
            this.Btn_TablasVerdad.Size = new System.Drawing.Size(303, 103);
            this.Btn_TablasVerdad.TabIndex = 3;
            this.Btn_TablasVerdad.Text = "Tablas de verdad";
            this.Btn_TablasVerdad.UseVisualStyleBackColor = true;
            this.Btn_TablasVerdad.Click += new System.EventHandler(this.Btn_TablasVerdad_Click);
            // 
            // Btn_Conjuntos
            // 
            this.Btn_Conjuntos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Conjuntos.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_Conjuntos.Location = new System.Drawing.Point(71, 173);
            this.Btn_Conjuntos.Name = "Btn_Conjuntos";
            this.Btn_Conjuntos.Size = new System.Drawing.Size(303, 103);
            this.Btn_Conjuntos.TabIndex = 4;
            this.Btn_Conjuntos.Text = "Conjuntos";
            this.Btn_Conjuntos.UseVisualStyleBackColor = true;
            this.Btn_Conjuntos.Click += new System.EventHandler(this.Btn_Conjuntos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Logo_Universidad);
            this.panel2.Location = new System.Drawing.Point(436, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 274);
            this.panel2.TabIndex = 5;
            // 
            // Logo_Universidad
            // 
            this.Logo_Universidad.ErrorImage = global::Proyecto_MatematicasDiscretas.Properties.Resources.Logotipo_Universidad;
            this.Logo_Universidad.Image = global::Proyecto_MatematicasDiscretas.Properties.Resources.Logotipo_Universidad;
            this.Logo_Universidad.ImageLocation = " ";
            this.Logo_Universidad.Location = new System.Drawing.Point(19, 17);
            this.Logo_Universidad.Name = "Logo_Universidad";
            this.Logo_Universidad.Size = new System.Drawing.Size(335, 244);
            this.Logo_Universidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_Universidad.TabIndex = 0;
            this.Logo_Universidad.TabStop = false;
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
            this.Btn_Minimizar.TabIndex = 7;
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
            this.Btn_Cerrar.TabIndex = 6;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Minimizar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_Conjuntos);
            this.Controls.Add(this.Btn_TablasVerdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Universidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_TablasVerdad;
        private System.Windows.Forms.Button Btn_Conjuntos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Logo_Universidad;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Cerrar;
    }
}

