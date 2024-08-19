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
    public partial class frmNovoFilme : Form
    {
        Contexto db = new Contexto();
        public frmNovoFilme()
        {
            InitializeComponent();

            List<Pais> paises = this.db.Pais.ToList();
            cbpais.DataSource = paises;
        }

        private void lbdataL_Click(object sender, EventArgs e)
        {

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            Filme novo = new Filme();
            novo.Nome = tbnome.Text;

            Pais pais = this.db.Pais
                  .Where(p => p.Nome == cbpais.SelectedItem.ToString())
                  .First();

            novo.Nacionalidade = pais;

            novo.AnoLancamento = (int)nupLancamento.Value;

            this.db.Filme.Add(novo);
            this.db.SaveChanges();

            
            MessageBox.Show("Sucesso!");
            this.Close();
        }

        private void cbpais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nupLancamento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNovoFilme_Load(object sender, EventArgs e)
        {

        }
    }
}
