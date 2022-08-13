namespace Proyecto_MatematicasDiscretas
{
    partial class Form_TablaVerdad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TablaVerdad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.txt_TablaVerdad = new System.Windows.Forms.TextBox();
            this.txt_Ingreso = new System.Windows.Forms.TextBox();
            this.Btn_GenerarTabla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 150);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(330, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLAS DE VERDAD";
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
            this.Btn_Minimizar.TabIndex = 31;
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
            this.Btn_Cerrar.TabIndex = 30;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
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
            this.Btn_Volver.TabIndex = 32;
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // txt_TablaVerdad
            // 
            this.txt_TablaVerdad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TablaVerdad.ForeColor = System.Drawing.Color.Black;
            this.txt_TablaVerdad.Location = new System.Drawing.Point(25, 196);
            this.txt_TablaVerdad.Multiline = true;
            this.txt_TablaVerdad.Name = "txt_TablaVerdad";
            this.txt_TablaVerdad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_TablaVerdad.Size = new System.Drawing.Size(851, 238);
            this.txt_TablaVerdad.TabIndex = 33;
            this.txt_TablaVerdad.WordWrap = false;
            // 
            // txt_Ingreso
            // 
            this.txt_Ingreso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ingreso.ForeColor = System.Drawing.Color.Black;
            this.txt_Ingreso.Location = new System.Drawing.Point(25, 122);
            this.txt_Ingreso.Multiline = true;
            this.txt_Ingreso.Name = "txt_Ingreso";
            this.txt_Ingreso.Size = new System.Drawing.Size(306, 57);
            this.txt_Ingreso.TabIndex = 34;
            this.txt_Ingreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_GenerarTabla
            // 
            this.Btn_GenerarTabla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerarTabla.ForeColor = System.Drawing.Color.ForestGreen;
            this.Btn_GenerarTabla.Location = new System.Drawing.Point(363, 122);
            this.Btn_GenerarTabla.Name = "Btn_GenerarTabla";
            this.Btn_GenerarTabla.Size = new System.Drawing.Size(270, 57);
            this.Btn_GenerarTabla.TabIndex = 35;
            this.Btn_GenerarTabla.Text = "Generar tabla";
            this.Btn_GenerarTabla.UseVisualStyleBackColor = true;
            this.Btn_GenerarTabla.Click += new System.EventHandler(this.Btn_GenerarTabla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Proposicion Compuesta";
            // 
            // Form_TablaVerdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_GenerarTabla);
            this.Controls.Add(this.txt_Ingreso);
            this.Controls.Add(this.txt_TablaVerdad);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.Btn_Minimizar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_TablaVerdad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_TablaVerdad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.TextBox txt_TablaVerdad;
        private System.Windows.Forms.TextBox txt_Ingreso;
        private System.Windows.Forms.Button Btn_GenerarTabla;
        private System.Windows.Forms.Label label2;
    }
}