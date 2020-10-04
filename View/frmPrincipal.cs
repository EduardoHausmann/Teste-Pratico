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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
