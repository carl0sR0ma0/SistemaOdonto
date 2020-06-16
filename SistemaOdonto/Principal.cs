using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void menuDentista_Click(object sender, EventArgs e)
        {
            CadDentista frm = new CadDentista();
            frm.ShowDialog();
        }

        private void menuAgDentistas_Click(object sender, EventArgs e)
        {
            ConDentista frm = new ConDentista();
            frm.ShowDialog();
        }

        private void menuPaciente_Click(object sender, EventArgs e)
        {
            CadPaciente frm = new CadPaciente();
            frm.ShowDialog();
        }

        private void menuAgPacientes_Click(object sender, EventArgs e)
        {
            ConPaciente frm = new ConPaciente();
            frm.ShowDialog();
        }
    }
}
