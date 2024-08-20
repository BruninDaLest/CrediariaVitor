namespace filmesApp2A
{
    partial class frmGerenciarElenco
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
            dgvAtores = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            btadicionar = new Button();
            btexcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvAtores
            // 
            dgvAtores.AutoGenerateColumns = false;
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvAtores.DataSource = atorBindingSource;
            dgvAtores.Location = new Point(84, 56);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.Size = new Size(335, 177);
            dgvAtores.TabIndex = 0;
            dgvAtores.CellClick += dgvAtores_CellClick;
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
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // btadicionar
            // 
            btadicionar.Location = new Point(84, 254);
            btadicionar.Name = "btadicionar";
            btadicionar.Size = new Size(75, 23);
            btadicionar.TabIndex = 1;
            btadicionar.Text = "Adicionar";
            btadicionar.UseVisualStyleBackColor = true;
            btadicionar.Click += btadicionar_Click;
            // 
            // btexcluir
            // 
            btexcluir.Enabled = false;
            btexcluir.Location = new Point(344, 254);
            btexcluir.Name = "btexcluir";
            btexcluir.Size = new Size(75, 23);
            btexcluir.TabIndex = 2;
            btexcluir.Text = "Excluir";
            btexcluir.UseVisualStyleBackColor = true;
            btexcluir.Click += btexcluir_Click;
            // 
            // frmGerenciarElenco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(btexcluir);
            Controls.Add(btadicionar);
            Controls.Add(dgvAtores);
            Name = "frmGerenciarElenco";
            Text = "Gerenciar Elenco";
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAtores;
        private Button btadicionar;
        private Button btexcluir;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
    }
}