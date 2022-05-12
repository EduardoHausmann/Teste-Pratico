using DAL;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmTemporada : Form
    {
        public frmTemporada()
        {
            InitializeComponent();
        }

        private void frmTemporada_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormTemporada = null;
        }

        private void frmTemporada_Load(object sender, EventArgs e)
        {
            this.temporadaBindingSource.DataSource = DataContextFactory.DataContext.Temporada;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.temporadaBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.temporadaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            dgvTemporada.Refresh();
            MessageBox.Show("Temporada salva com sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.temporadaBindingSource.CancelEdit();
        }
    }
}
