namespace Aula10_Ex01
{
    public partial class Colecao : Form
    {
        List<Manga> lista = new List<Manga>();

        public Colecao()
        {
            InitializeComponent();
        }

        private void Colecao_Load(object sender, EventArgs e)
        {
            lista.Add(new Manga("Bleach"));
            lista.Add(new Manga("Chainsaw Man"));
            lista.Add(new Manga("Blue Lock"));

            AtualizarLista();
        }

        void AtualizarLista()
        {
            listview.Items.Clear();

            foreach (var item in lista)
            {
                listview.Items.Add(new ListViewItem(item.nomeManga));
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro(lista);
            cadastro.ShowDialog();
            AtualizarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creditos credito = new Creditos();
            credito.ShowDialog();
        }
    }
}
