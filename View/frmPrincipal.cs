using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmTemporada_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormTemporada == null)
                MeusFormularios.FormTemporada = new frmTemporada();

            MeusFormularios.FormTemporada.Show();
            MeusFormularios.FormTemporada.Focus();
        }

        private void tsmJogo_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormJogo == null)
                MeusFormularios.FormJogo = new frmJogo();

            MeusFormularios.FormJogo.Show();
            MeusFormularios.FormJogo.Focus();
        }

        private void tsmConsultaJogo_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormConsulta == null)
                MeusFormularios.FormConsulta = new frmConsulta();

            MeusFormularios.FormConsulta.Show();
            MeusFormularios.FormConsulta.Focus();
        }
    }
}
