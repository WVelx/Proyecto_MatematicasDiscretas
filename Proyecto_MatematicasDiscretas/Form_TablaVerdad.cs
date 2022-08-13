using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MatematicasDiscretas
{
    public partial class Form_TablaVerdad : Form
    {
        private char[] Preposiciones = { 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z', 'a', 'b', 'c'};
        public Form_TablaVerdad()
        {
            InitializeComponent();
        }

        Int64 Potencia(Int64 x)
        {
            if (x == 0)
                return 1;
            else
                return 2 * Potencia(x - 1);
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Btn_GenerarTabla_Click(object sender, EventArgs e)
        {
            txt_TablaVerdad.Clear();

            Int64 x1, x2, c, i, j, n, exp;

            c = 0;
            x2 = 0;

            //introducimos el valor de n 
            n = Convert.ToInt64(txt_Ingreso.Text);

            //comprobamos que el valor de n sea mayor a 0 y llamamos al metodo potencia para llenar la tabla de verdad
            if (n > 0)
            {
                exp = Potencia(n);
                String[,] mat = new string[exp, n];
                x1 = exp / 2;

                for (j = 0; j < n; j++)
                {
                    for (i = 0; i < exp; i++)
                    {
                        if (x2 == 0)
                        {
                            mat[i, j] = "V";
                            c++;
                        }
                        else if (x2 == 1)
                        {
                            mat[i, j] = "F";
                            c--;
                        }
                        if (c == x1)
                        {
                            x2 = 1;
                        }
                        if (c == 0)
                        {
                            x2 = 0;
                        }
                    }
                    x1 = x1 / 2;
                }
                //imprimimos la tabla de verdad
                for (j = 0; j < n; j++)
                {
                    txt_TablaVerdad.Text = txt_TablaVerdad.Text + "|   " + Preposiciones[j] + "    |";
                    label3.Text = label3.Text + "|   " + Preposiciones[j] + "    |";
                }
                txt_TablaVerdad.Text = txt_TablaVerdad.Text + "\r\n";
                for (i = 0; i < exp; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        txt_TablaVerdad.Text = txt_TablaVerdad.Text + "|   " + Convert.ToString(mat[i, j]) + "   |";
                        label3.Text = label3.Text + "|   " + Convert.ToString(mat[i, j]) + "   |";
                    }
                    txt_TablaVerdad.Text = txt_TablaVerdad.Text + "\r\n";
                }
                txt_Ingreso.Clear();
            }
            else
            {
                MessageBox.Show("ERROR, POR FAVOR INTRODUZCA UN VALOR MAYOR A 0");
                txt_Ingreso.Clear();
            }
        }
    }
}
