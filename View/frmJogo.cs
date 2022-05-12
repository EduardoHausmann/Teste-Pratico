using DAL;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmJogo : Form
    {
        public frmJogo()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormJogo = null;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.jogoBindingSource.DataSource = DataContextFactory.DataContext.Jogo;
            this.temporadaBindingSource.DataSource = DataContextFactory.DataContext.Temporada;
        }

        private void jogoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 2)
                e.Value = ((Temporada)e.Value).Inicio;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.jogoBindingSource.AddNew();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.jogoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                jogoDataGridView.Refresh();
                MessageBox.Show("Jogo salvo com sucesso!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.jogoBindingSource.CancelEdit();
        }

        public bool Valida()
        {
            if (txtPontuacao.Text == string.Empty)
            {
                MessageBox.Show("O campo pontuação é obrogatório");
                txtPontuacao.Focus();
                return false;
            }
            return true;
        }
    }
}
