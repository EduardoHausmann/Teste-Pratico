namespace View
{
    partial class frmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblTemporada;
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblOla = new System.Windows.Forms.Label();
            this.jogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvJogo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTemporada = new System.Windows.Forms.ComboBox();
            this.temporadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConsultar = new System.Windows.Forms.Button();
            lblTemporada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporadaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemporada
            // 
            lblTemporada.AutoSize = true;
            lblTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTemporada.Location = new System.Drawing.Point(12, 94);
            lblTemporada.Name = "lblTemporada";
            lblTemporada.Size = new System.Drawing.Size(90, 20);
            lblTemporada.TabIndex = 6;
            lblTemporada.Text = "Temporada";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.Location = new System.Drawing.Point(12, 34);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(270, 40);
            this.lblPontuacao.TabIndex = 5;
            this.lblPontuacao.Text = "Placar dos seus jogos com \r\nmelhores pontuações por temporada\r\n";
            // 
            // lblOla
            // 
            this.lblOla.AutoSize = true;
            this.lblOla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOla.Location = new System.Drawing.Point(12, 9);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(85, 20);
            this.lblOla.TabIndex = 4;
            this.lblOla.Text = "Olá Maria";
            // 
            // jogoBindingSource
            // 
            this.jogoBindingSource.DataSource = typeof(DAL.Jogo);
            // 
            // dgvJogo
            // 
            this.dgvJogo.AllowUserToAddRows = false;
            this.dgvJogo.AllowUserToDeleteRows = false;
            this.dgvJogo.AutoGenerateColumns = false;
            this.dgvJogo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dgvJogo.DataSource = this.jogoBindingSource;
            this.dgvJogo.Location = new System.Drawing.Point(16, 151);
            this.dgvJogo.Name = "dgvJogo";
            this.dgvJogo.ReadOnly = true;
            this.dgvJogo.RowHeadersVisible = false;
            this.dgvJogo.Size = new System.Drawing.Size(306, 220);
            this.dgvJogo.TabIndex = 6;
            this.dgvJogo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvJogo_CellFormatting);
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
            // cbTemporada
            // 
            this.cbTemporada.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jogoBindingSource, "CodigoTemporada", true));
            this.cbTemporada.DataSource = this.temporadaBindingSource;
            this.cbTemporada.DisplayMember = "Inicio";
            this.cbTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemporada.FormatString = "d";
            this.cbTemporada.FormattingEnabled = true;
            this.cbTemporada.Location = new System.Drawing.Point(16, 117);
            this.cbTemporada.Name = "cbTemporada";
            this.cbTemporada.Size = new System.Drawing.Size(177, 28);
            this.cbTemporada.TabIndex = 7;
            this.cbTemporada.ValueMember = "CodigoTemporada";
            // 
            // temporadaBindingSource
            // 
            this.temporadaBindingSource.DataSource = typeof(DAL.Temporada);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(233, 116);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 28);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 379);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(lblTemporada);
            this.Controls.Add(this.cbTemporada);
            this.Controls.Add(this.dgvJogo);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblOla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Consulta de Jogo por Temporada:.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsulta_FormClosed);
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporadaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.BindingSource jogoBindingSource;
        private System.Windows.Forms.DataGridView dgvJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cbTemporada;
        private System.Windows.Forms.BindingSource temporadaBindingSource;
        private System.Windows.Forms.Button btnConsultar;
    }
}