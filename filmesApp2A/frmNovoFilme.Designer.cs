namespace filmesApp2A
{
    partial class frmNovoFilme
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
            lbdataL = new Label();
            lbpais = new Label();
            tbnome = new TextBox();
            label3 = new Label();
            btcadastrar = new Button();
            cbpais = new ComboBox();
            nupLancamento = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nupLancamento).BeginInit();
            SuspendLayout();
            // 
            // lbdataL
            // 
            lbdataL.AutoSize = true;
            lbdataL.Location = new Point(153, 115);
            lbdataL.Name = "lbdataL";
            lbdataL.Size = new Size(46, 15);
            lbdataL.TabIndex = 0;
            lbdataL.Text = "Nome :";
            lbdataL.Click += lbdataL_Click;
            // 
            // lbpais
            // 
            lbpais.AutoSize = true;
            lbpais.Location = new Point(162, 154);
            lbpais.Name = "lbpais";
            lbpais.Size = new Size(37, 15);
            lbpais.TabIndex = 1;
            lbpais.Text = "Pais : ";
            // 
            // tbnome
            // 
            tbnome.Location = new Point(205, 107);
            tbnome.Name = "tbnome";
            tbnome.Size = new Size(100, 23);
            tbnome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 186);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 5;
            label3.Text = "Lançamento : ";
            // 
            // btcadastrar
            // 
            btcadastrar.Location = new Point(205, 232);
            btcadastrar.Name = "btcadastrar";
            btcadastrar.Size = new Size(75, 23);
            btcadastrar.TabIndex = 6;
            btcadastrar.Text = "Cadastrar";
            btcadastrar.UseVisualStyleBackColor = true;
            btcadastrar.Click += btcadastrar_Click;
            // 
            // cbpais
            // 
            cbpais.FormattingEnabled = true;
            cbpais.Location = new Point(205, 146);
            cbpais.Name = "cbpais";
            cbpais.Size = new Size(100, 23);
            cbpais.TabIndex = 7;
            cbpais.SelectedIndexChanged += cbpais_SelectedIndexChanged;
            // 
            // nupLancamento
            // 
            nupLancamento.Location = new Point(205, 186);
            nupLancamento.Name = "nupLancamento";
            nupLancamento.Size = new Size(100, 23);
            nupLancamento.TabIndex = 8;
            nupLancamento.ValueChanged += nupLancamento_ValueChanged;
            // 
            // frmNovoFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nupLancamento);
            Controls.Add(cbpais);
            Controls.Add(btcadastrar);
            Controls.Add(label3);
            Controls.Add(tbnome);
            Controls.Add(lbpais);
            Controls.Add(lbdataL);
            Name = "frmNovoFilme";
            Text = "Novo Filme";
            Load += frmNovoFilme_Load;
            ((System.ComponentModel.ISupportInitialize)nupLancamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdataL;
        private Label lbpais;
        private TextBox tbnome;
        private Label label3;
        private Button btcadastrar;
        private ComboBox cbpais;
        private NumericUpDown nupLancamento;
    }
}