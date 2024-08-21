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
    public partial class frmGerenciarElenco : Form
    {
        Filme filme;
        Contexto db;
        public frmGerenciarElenco(Contexto db, Filme filme)
        {
            InitializeComponent();
            this.filme = filme;
            this.db = db;

            dgvAtores.DataSource = filme.Atores;
        }

        private void btadicionar_Click(object sender, EventArgs e)
        {
            frmNovoAtorElenco f = new frmNovoAtorElenco(db, filme);
            f.ShowDialog();

            Pesquisar("");

        }
        public void Pesquisar(string busca)
        {
            List<Ator> atores = this.db.Ator
                .Where(a => a.Filmes.Contains(filme))
                .ToList();
            dgvAtores.DataSource = atores;
        }
        Ator selecionado;
        private void btexcluir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
             "Deseja mesmo remover o ator " + selecionado.Nome + "?",
             "Confirmação",
             MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {

                filme.Atores.Remove(selecionado);
                this.db.Filme.Update(filme);
                this.db.SaveChanges();

                btexcluir.Enabled = false;
                Pesquisar("");


            }
        }

        private void dgvAtores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvAtores.SelectedCells[0].RowIndex;
            int id = (int)dgvAtores.Rows[linha].Cells[0].Value;

            selecionado = this.db.Ator.Where(f => f.Id == id).First();

            btexcluir.Enabled = true;
        }

        private void dgvAtores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
