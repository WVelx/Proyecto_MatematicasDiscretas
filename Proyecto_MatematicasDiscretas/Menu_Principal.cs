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

    public partial class Menu_Principal : Form
    {

        Form_Conjuntos conjuntos = new Form_Conjuntos();
        Form_TablaVerdad tablaverd = new Form_TablaVerdad();

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Conjuntos_Click(object sender, EventArgs e)
        {
            conjuntos.Visible = true;
        }

        private void Btn_TablasVerdad_Click(object sender, EventArgs e)
        {
            tablaverd.Visible = true;
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
    }
}
