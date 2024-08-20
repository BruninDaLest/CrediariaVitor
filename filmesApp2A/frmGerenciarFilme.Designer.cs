﻿namespace filmesApp2A
{
    partial class frmGerenciarFilme
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
            components = new System.ComponentModel.Container();
            txtPesquisar = new TextBox();
            btpesquisar = new Button();
            btadicionar = new Button();
            btgerenciarelenco = new Button();
            bteditar = new Button();
            btexcluir = new Button();
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(41, 35);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(282, 23);
            txtPesquisar.TabIndex = 0;
            // 
            // btpesquisar
            // 
            btpesquisar.Location = new Point(329, 35);
            btpesquisar.Name = "btpesquisar";
            btpesquisar.Size = new Size(94, 23);
            btpesquisar.TabIndex = 1;
            btpesquisar.Text = "Pesquisar";
            btpesquisar.UseVisualStyleBackColor = true;
            btpesquisar.Click += btpeaquisar_Click;
            // 
            // btadicionar
            // 
            btadicionar.Location = new Point(41, 235);
            btadicionar.Name = "btadicionar";
            btadicionar.Size = new Size(75, 23);
            btadicionar.TabIndex = 2;
            btadicionar.Text = "Adicionar";
            btadicionar.UseVisualStyleBackColor = true;
            btadicionar.Click += btadicionar_Click;
            // 
            // btgerenciarelenco
            // 
            btgerenciarelenco.Enabled = false;
            btgerenciarelenco.Location = new Point(204, 235);
            btgerenciarelenco.Name = "btgerenciarelenco";
            btgerenciarelenco.Size = new Size(108, 23);
            btgerenciarelenco.TabIndex = 3;
            btgerenciarelenco.Text = "Gerenciar Elenco";
            btgerenciarelenco.UseVisualStyleBackColor = true;
            btgerenciarelenco.Click += btgerenciarelenco_Click;
            // 
            // bteditar
            // 
            bteditar.Enabled = false;
            bteditar.Location = new Point(318, 235);
            bteditar.Name = "bteditar";
            bteditar.Size = new Size(49, 23);
            bteditar.TabIndex = 4;
            bteditar.Text = "Editar";
            bteditar.UseVisualStyleBackColor = true;
            bteditar.Click += bteditar_Click;
            // 
            // btexcluir
            // 
            btexcluir.Enabled = false;
            btexcluir.Location = new Point(373, 235);
            btexcluir.Name = "btexcluir";
            btexcluir.Size = new Size(50, 23);
            btexcluir.TabIndex = 5;
            btexcluir.Text = "Excluir";
            btexcluir.UseVisualStyleBackColor = true;
            btexcluir.Click += btexcluir_Click;
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, anoLancamentoDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = filmeBindingSource;
            dgvFilmes.Location = new Point(41, 64);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.Size = new Size(382, 165);
            dgvFilmes.TabIndex = 6;
            dgvFilmes.CellClick += dgvFilmes_CellClick;
            dgvFilmes.CellContentClick += dgvFilmes_CellContentClick_1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // anoLancamentoDataGridViewTextBoxColumn
            // 
            anoLancamentoDataGridViewTextBoxColumn.DataPropertyName = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.HeaderText = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.Name = "anoLancamentoDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Models.Filme);
            // 
            // frmGerenciarFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 325);
            Controls.Add(dgvFilmes);
            Controls.Add(btexcluir);
            Controls.Add(bteditar);
            Controls.Add(btgerenciarelenco);
            Controls.Add(btadicionar);
            Controls.Add(btpesquisar);
            Controls.Add(txtPesquisar);
            Name = "frmGerenciarFilme";
            Text = "Gerenciar Filme";
            FormClosing += frmGerenciarFilme_FormClosing;
            Load += frmGerenciarFilme_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisar;
        private Button btpesquisar;
        private Button btadicionar;
        private Button btgerenciarelenco;
        private Button bteditar;
        private Button btexcluir;
        private DataGridView dgvFilmes;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
    }
}