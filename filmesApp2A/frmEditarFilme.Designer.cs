namespace filmesApp2A
{
    partial class frmEditarFilme
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
            txtNome = new TextBox();
            label1 = new Label();
            btSalvar = new Button();
            dgvAtores = new DataGridView();
            cbxPais = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            nupLancamento = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupLancamento).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(158, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(197, 23);
            txtNome.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 44);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(213, 159);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 11;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // dgvAtores
            // 
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Location = new Point(57, 202);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.Size = new Size(491, 216);
            dgvAtores.TabIndex = 10;
            // 
            // cbxPais
            // 
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.FormattingEnabled = true;
            cbxPais.Location = new Point(158, 80);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(197, 23);
            cbxPais.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 127);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "Ano Lançamento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 88);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 7;
            label2.Text = "Nacionalidade:";
            // 
            // nupLancamento
            // 
            nupLancamento.Location = new Point(158, 119);
            nupLancamento.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            nupLancamento.Name = "nupLancamento";
            nupLancamento.Size = new Size(197, 23);
            nupLancamento.TabIndex = 12;
            // 
            // frmEditarFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 450);
            Controls.Add(nupLancamento);
            Controls.Add(btSalvar);
            Controls.Add(dgvAtores);
            Controls.Add(cbxPais);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "frmEditarFilme";
            Text = "frmEditarFilme";
            Load += frmEditarFilme_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupLancamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Button btSalvar;
        private DataGridView dgvAtores;
        private ComboBox cbxPais;
        private Label label3;
        private Label label2;
        private NumericUpDown nupLancamento;
    }
}