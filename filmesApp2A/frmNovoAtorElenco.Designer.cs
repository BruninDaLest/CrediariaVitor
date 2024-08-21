namespace filmesApp2A
{
    partial class frmNovoAtorElenco
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
            btAdicionar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(192, 142);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(75, 23);
            btAdicionar.TabIndex = 0;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 83);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(266, 23);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // frmNovoAtorElenco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 228);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btAdicionar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmNovoAtorElenco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir Ator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAdicionar;
        private Label label1;
        private TextBox txtNome;
    }
}