using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void altaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesAlta ofrmClientesAlta = new FrmClientesAlta();
            ofrmClientesAlta.Show();
        }

        private void altaDePeriodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeriodosAlta ofrmPeriodosAlta = new FrmPeriodosAlta();
            ofrmPeriodosAlta.Show();
        }

        private void altaDeDireccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDestinosAlta ofrmDestinosAlta = new FrmDestinosAlta();
            ofrmDestinosAlta.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioAlta ofrmAgregarUsuario = new FrmUsuarioAlta();
            ofrmAgregarUsuario.Show();
        }
    }
}
