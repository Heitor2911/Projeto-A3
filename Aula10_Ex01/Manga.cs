using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Ex01
{
    public class Manga
    {
        //Atributos

        public string nomeManga;
        public int edicaoManga;
        public float preco;

        public Manga(string nome)
        {
            this.nomeManga = nome;
        }
    }
}
