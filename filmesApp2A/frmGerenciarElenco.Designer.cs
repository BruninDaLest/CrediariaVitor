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
            atorBindingSource = new BindingSource(components);
            btadicionar = new Button();
            btexcluir = new Button();
            atorBindingSource1 = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvAtores
            // 
            dgvAtores.AutoGenerateColumns = false;
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvAtores.DataSource = atorBindingSource1;
            dgvAtores.Location = new Point(84, 56);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.Size = new Size(335, 177);
            dgvAtores.TabIndex = 0;
            dgvAtores.CellClick += dgvAtores_CellClick;
            dgvAtores.CellContentClick += dgvAtores_CellContentClick;
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
            // atorBindingSource1
            // 
            atorBindingSource1.DataSource = typeof(Models.Ator);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Nacionalidade";
            dataGridViewTextBoxColumn3.HeaderText = "Nacionalidade";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            ((System.ComponentModel.ISupportInitialize)atorBindingSource1).EndInit();
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource atorBindingSource1;
    }
}