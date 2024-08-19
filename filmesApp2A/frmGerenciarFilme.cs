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
    public partial class frmGerenciarFilme : Form
    {
        Contexto db;

        Form anterior;
        public frmGerenciarFilme(Form anterior)
        {
            InitializeComponent();
            this.db = new Contexto();
            this.anterior = anterior;
        }

        private void frmGerenciarFilme_Load(object sender, EventArgs e)
        {

        }

        private void btpeaquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(txtPesquisar.Text);

        }

        public void Pesquisar(string busca)
        {
            List<Filme> filmes = this.db.Filme
                .Where(a => a.Nome.ToUpper().Contains(busca.ToUpper()))
                .ToList();

            dgvFilmes.DataSource = filmes;
        }

        private void btadicionar_Click(object sender, EventArgs e)
        {
            frmNovoFilme f = new frmNovoFilme();
            f.ShowDialog();
            Pesquisar(btpesquisar.Text);
        }

        private void btgerenciarelenco_Click(object sender, EventArgs e)
        {

        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            frmEditarFilme f = new frmEditarFilme(selecionado);
            f.ShowDialog();
            Pesquisar(txtPesquisar.Text);
        }

        Filme selecionado;
        private void dgvFilmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvFilmes.SelectedCells[0].RowIndex;
            int id = (int)dgvFilmes.Rows[linha].Cells[0].Value;

            selecionado = this.db.Filme.Where(f => f.Id == id).First();

            bteditar.Enabled = true;
            btexcluir.Enabled = true;
            btgerenciarelenco.Enabled = true;
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
               "Deseja mesmo remover o ator " + selecionado.Nome + "?",
               "Confirmação",
               MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.db.Filme.Remove(selecionado);
                this.db.SaveChanges();

                bteditar.Enabled = false;
                btexcluir.Enabled = false;

                Pesquisar(txtPesquisar.Text);
            }
        }
    }
}
