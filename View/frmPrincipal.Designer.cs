namespace View
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.jogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOla = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.temporadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporadaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jogoBindingSource
            // 
            this.jogoBindingSource.DataSource = typeof(DAL.Jogo);
            // 
            // jogoDataGridView
            // 
            this.jogoDataGridView.AllowUserToAddRows = false;
            this.jogoDataGridView.AllowUserToDeleteRows = false;
            this.jogoDataGridView.AutoGenerateColumns = false;
            this.jogoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jogoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.jogoDataGridView.DataSource = this.jogoBindingSource;
            this.jogoDataGridView.Location = new System.Drawing.Point(25, 63);
            this.jogoDataGridView.Name = "jogoDataGridView";
            this.jogoDataGridView.ReadOnly = true;
            this.jogoDataGridView.RowHeadersVisible = false;
            this.jogoDataGridView.Size = new System.Drawing.Size(306, 256);
            this.jogoDataGridView.TabIndex = 1;
            this.jogoDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.jogoDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoJogo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pontuacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pontuação";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Temporada";
            this.dataGridViewTextBoxColumn4.HeaderText = "Temporada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblOla
            // 
            this.lblOla.AutoSize = true;
            this.lblOla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOla.Location = new System.Drawing.Point(12, 9);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(85, 20);
            this.lblOla.TabIndex = 2;
            this.lblOla.Text = "Olá Maria";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.Location = new System.Drawing.Point(12, 40);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(329, 20);
            this.lblPontuacao.TabIndex = 3;
            this.lblPontuacao.Text = "Placar dos seus jogos com melhor pontuação";
            // 
            // temporadaBindingSource
            // 
            this.temporadaBindingSource.DataSource = typeof(DAL.Temporada);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 339);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblOla);
            this.Controls.Add(this.jogoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.Text = "Tela Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporadaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource jogoBindingSource;
        private System.Windows.Forms.DataGridView jogoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.BindingSource temporadaBindingSource;
    }
}

