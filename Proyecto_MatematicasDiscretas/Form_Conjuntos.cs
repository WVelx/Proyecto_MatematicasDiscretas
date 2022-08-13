using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MatematicasDiscretas.Clases;

namespace Proyecto_MatematicasDiscretas
{
    public partial class Form_Conjuntos : Form
    {
        private HashSet<string> conjuntoA = new HashSet<string>();
        private HashSet<string> conjuntoB = new HashSet<string>();
        private HashSet<string> unionAB = new HashSet<string>();
        private HashSet<string> interseccionAB = new HashSet<string>();
        private HashSet<string> diferenciaAB = new HashSet<string>();
        private HashSet<string> diferenciaBA = new HashSet<string>();
        private HashSet<string> diferenciaSimetrica = new HashSet<string>();

        Class_ConjuntoDoble conjunto;

        public Form_Conjuntos()
        {
            InitializeComponent();
        }

        public void obtenerElementosConjuntoA()
        {
            this.conjuntoA.Clear();
            for (int i = 0; i < this.txt_ConjuntoA.Lines.Count(); i++)
            {
                this.conjuntoA.Add(this.txt_ConjuntoA.Lines[i]);
            }
        }

        public void obtenerElementosConjuntoB()
        {
            this.conjuntoB.Clear();
            for (int i = 0; i < this.txt_ConjuntoB.Lines.Count(); i++)
            {
                this.conjuntoB.Add(this.txt_ConjuntoB.Lines[i]);
            }
        }

        public void Operar()
        {
            obtenerElementosConjuntoA();
            obtenerElementosConjuntoB();

            conjunto = new Class_ConjuntoDoble(this.conjuntoA, this.conjuntoB);
            unionAB = conjunto.operarUnion();
            interseccionAB = conjunto.operarInterseccion();
            diferenciaAB = conjunto.operarDiferenciaAB();
            diferenciaBA = conjunto.operarDiferenciaBA();
            diferenciaSimetrica = conjunto.operarDiferenciaSimetrica();
        }

        private void ActivarBotones()
        {
            this.txt_ConjuntoA.Enabled = true;
            this.txt_ConjuntoB.Enabled = true;

            this.Btn_Union.Enabled = true;
            this.Btn_Interseccion.Enabled = true;
            this.Btn_DiffSimetrica.Enabled = true;
            this.Btn_ADiffB.Enabled = true;
            this.Btn_BDiffA.Enabled = true;

            this.Btn_Limpiar.Enabled = false;
        }

        private void DesactivarBotones()
        {
            this.txt_ConjuntoA.Enabled = false;
            this.txt_ConjuntoB.Enabled = false;

            this.Btn_Union.Enabled = false;
            this.Btn_Interseccion.Enabled = false;
            this.Btn_DiffSimetrica.Enabled = false;
            this.Btn_ADiffB.Enabled = false;
            this.Btn_BDiffA.Enabled = false;

            this.Btn_Limpiar.Enabled = true;
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            ActivarBotones();
            this.txt_Resultados.Clear();
            Diagrama_Veen.Image = Proyecto_MatematicasDiscretas.Properties.Resources.Normal;
        }

        private void Btn_Union_Click(object sender, EventArgs e)
        {
            Operar();
            DesactivarBotones();
            Diagrama_Veen.Image = Proyecto_MatematicasDiscretas.Properties.Resources.Union;
            if (unionAB.Count == 0)
            {
                this.txt_Resultados.Text = "Conjunto Vacio";
            }
            else
            {
                this.txt_Resultados.Text = "{ ";
                foreach (string elemento in unionAB)
                {
                    if (elemento != "" || elemento != null)
                    {
                        this.txt_Resultados.Text += (elemento + ", ");
                    }     
                }
                this.txt_Resultados.Text += " }";
            }
        }

        private void Btn_Interseccion_Click(object sender, EventArgs e)
        {
            Operar();
            DesactivarBotones();
            Diagrama_Veen.Image = Proyecto_MatematicasDiscretas.Properties.Resources.Interseccion;
            if (interseccionAB.Count == 0)
            {
                this.txt_Resultados.Text = "Conjunto Vacio";
            }
            else
            {
                this.txt_Resultados.Text = "{ ";
                foreach (string elemento in interseccionAB)
                {
                    if (elemento != "" || elemento != null)
                    {
                        this.txt_Resultados.Text += (elemento + ", ");
                    }
                }
                this.txt_Resultados.Text += " }";
            }
        }

        private void Btn_DiffSimetrica_Click(object sender, EventArgs e)
        {
            Operar();
            DesactivarBotones();
            Diagrama_Veen.Image = Proyecto_MatematicasDiscretas.Properties.Resources.DiffSimetrica;
            if (diferenciaSimetrica.Count == 0)
            {
                this.txt_Resultados.Text = "Conjunto Vacio";
            }
            else
            {
                this.txt_Resultados.Text = "{ ";
                foreach (string elemento in diferenciaSimetrica)
                {
                    if (elemento != "" || elemento != null)
                    {
                        this.txt_Resultados.Text += (elemento + ", ");
                    }
                }
                this.txt_Resultados.Text += " }";
            }
        }

        private void Btn_ADiffB_Click(object sender, EventArgs e)
        {
            Operar();
            DesactivarBotones();
            Diagrama_Veen.Image = Proyecto_MatematicasDiscretas.Properties.Resources.AdifB;
            if (diferenciaAB.Count == 0)
            {
                this.txt_Resultados.Text = "Conjunto Vacio";
            }
            else
            {
                this.txt_Resultados.Text = "{ ";
                foreach (string elemento in diferenciaAB)
                {
                    if (elemento != "" || elemento != null)
                    {
                        this.txt_Resultados.Text += (elemento + ", ");
                    }
                }
                this.txt_Resultados.Text += " }";
            }
        }

        private void Btn_BDiffA_Click(object sender, EventArgs e)
        {
            Operar();
            DesactivarBotones();
            Diagrama_Veen.Image = Proyecto_MatematicasDiscretas.Properties.Resources.BdiffA;
            if (diferenciaBA.Count == 0)
            {
                this.txt_Resultados.Text = "Conjunto Vacio";
            }
            else
            {
                this.txt_Resultados.Text = "{ ";
                foreach (string elemento in diferenciaBA)
                {
                    if (elemento != "" || elemento != null)
                    {
                        this.txt_Resultados.Text += (elemento + ", ");
                    }
                }
                this.txt_Resultados.Text += " }";
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
