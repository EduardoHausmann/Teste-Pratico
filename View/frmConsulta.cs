using DAL;
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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            this.jogoBindingSource.DataSource = DataContextFactory.DataContext.Jogo;
            this.temporadaBindingSource.DataSource = DataContextFactory.DataContext.Temporada;
        }

        private void frmConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormConsulta = null;
        }

        private void dgvJogo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 2)
                e.Value = ((Temporada)e.Value).Inicio;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Consultar((int)cbTemporada.SelectedValue);
        }

        public void Consultar(int codigoTemporada)
        {
            this.jogoBindingSource.DataSource = DataContextFactory.DataContext.Jogo.Where(x => x.CodigoTemporada == codigoTemporada);
        }
    }
}
