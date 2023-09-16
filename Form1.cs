using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso_a_pacientes
{
    public partial class Forma1 : Form
    {
        public Forma1()
        {
            InitializeComponent();
        }

        private void cmdaceptar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "JJHR" & txtcontra.Text == "0000")
            {
                Forma2 forma2 = new Forma2();
                forma2.Show(this);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
                txtusuario.Clear();
                txtcontra.Clear();
                txtusuario.Focus();
            }
        }

        private void cmdsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
