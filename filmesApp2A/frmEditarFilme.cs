using filmesApp2A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp2A
{
    public partial class frmEditarFilme : Form
    {
        Contexto db;
        Filme filme;
        public frmEditarFilme(Filme filme)
        {
            InitializeComponent();
            this.db = new Contexto();
            this.filme = filme;

            txtNome.Text = filme.Nome;
            nupLancamento.Value = (decimal) filme.AnoLancamento;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            filme.Nome = txtNome.Text;
            Pais pais = this.db.Pais
                        .Where(p => p.Nome == cbxPais.SelectedItem.ToString())
                        .First();
            filme.Nacionalidade = pais;
            filme.AnoLancamento = (int)nupLancamento.Value;

            this.db.Filme.Update(filme);
            this.db.SaveChanges();
            MessageBox.Show("Sucesso!");
        }
    }
}
