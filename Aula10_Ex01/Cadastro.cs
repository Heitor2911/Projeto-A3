using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula10_Ex01
{
    public partial class Cadastro : Form
    {
        List<Manga> lista;

        public Cadastro(List<Manga> lista)
        {
            InitializeComponent();

            this.lista = lista;
        }

        private void lblNovo2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            Manga novoManga = new Manga(nome);

            lista.Add(novoManga);

            Close();
        }
    }
}
