using filmesApp2A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp2A
{
    public partial class frmNovoAtorElenco : Form
    {
        Filme filme;
        Contexto db;
        public frmNovoAtorElenco(Contexto db, Filme filme)
        {
            InitializeComponent();
            this.filme = filme;
            this.db = db;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {


            string nome = txtNome.Text;

            Ator? ator = db.Ator.Where(a => a.Nome.ToUpper() == nome.ToUpper()).FirstOrDefault();

            if (ator != null)
            {
                this.filme.Atores.Add(ator);
                this.db.Filme.Update(this.filme);
                this.db.SaveChanges();
                MessageBox.Show("Sucesso!");
            }
            else
                MessageBox.Show("Ator não existe");

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
