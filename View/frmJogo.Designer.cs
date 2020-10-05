namespace View
{
    partial class frmJogo
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
            System.Windows.Forms.Label lblPontuacao;
            System.Windows.Forms.Label lblTemporada;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.jogoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPontuacao = new System.Windows.Forms.TextBox();
            this.cbTemporada = new System.Windows.Forms.ComboBox();
            this.temporadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lblPontuacao = new System.Windows.Forms.Label();
            lblTemporada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jogoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporadaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPontuacao
            // 
            lblPontuacao.AutoSize = true;
            lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPontuacao.Location = new System.Drawing.Point(27, 10);
            lblPontuacao.Name = "lblPontuacao";
            lblPontuacao.Size = new System.Drawing.Size(86, 20);
            lblPontuacao.TabIndex = 6;
            lblPontuacao.Text = "Pontuação";
            // 
            // lblTemporada
            // 
            lblTemporada.AutoSize = true;
            lblTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTemporada.Location = new System.Drawing.Point(27, 72);
            lblTemporada.Name = "lblTemporada";
            lblTemporada.Size = new System.Drawing.Size(90, 20);
            lblTemporada.TabIndex = 8;
            lblTemporada.Text = "Temporada";
            // 
            // jogoDataGridView
            // 
            this.jogoDataGridView.AllowUserToAddRows = false;
            this.jogoDataGridView.AllowUserToDeleteRows = false;
            this.jogoDataGridView.AutoGenerateColumns = false;
            this.jogoDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.jogoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jogoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.jogoDataGridView.DataSource = this.jogoBindingSource;
            this.jogoDataGridView.Location = new System.Drawing.Point(12, 171);
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Temporada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // jogoBindingSource
            // 
            this.jogoBindingSource.DataSource = typeof(DAL.Jogo);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(27, 129);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(86, 35);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(119, 129);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(86, 35);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(211, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogoBindingSource, "Pontuacao", true));
            this.txtPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontuacao.Location = new System.Drawing.Point(27, 33);
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.Size = new System.Drawing.Size(270, 26);
            this.txtPontuacao.TabIndex = 7;
            // 
            // cbTemporada
            // 
            this.cbTemporada.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jogoBindingSource, "CodigoTemporada", true));
            this.cbTemporada.DataSource = this.temporadaBindingSource;
            this.cbTemporada.DisplayMember = "Inicio";
            this.cbTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemporada.FormatString = "d";
            this.cbTemporada.FormattingEnabled = true;
            this.cbTemporada.Location = new System.Drawing.Point(27, 95);
            this.cbTemporada.Name = "cbTemporada";
            this.cbTemporada.Size = new System.Drawing.Size(270, 28);
            this.cbTemporada.TabIndex = 9;
            this.cbTemporada.ValueMember = "CodigoTemporada";
            // 
            // temporadaBindingSource
            // 
            this.temporadaBindingSource.DataSource = typeof(DAL.Temporada);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 431);
            this.Controls.Add(lblTemporada);
            this.Controls.Add(this.cbTemporada);
            this.Controls.Add(lblPontuacao);
            this.Controls.Add(this.txtPontuacao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.jogoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Jogo :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jogoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporadaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource jogoBindingSource;
        private System.Windows.Forms.DataGridView jogoDataGridView;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPontuacao;
        private System.Windows.Forms.ComboBox cbTemporada;
        private System.Windows.Forms.BindingSource temporadaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

