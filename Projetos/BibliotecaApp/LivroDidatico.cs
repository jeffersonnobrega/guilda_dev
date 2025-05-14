using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
    public class LivroDidatico: Livro
    {
        public string Disciplina { get; set; }

        public LivroDidatico(string titulo, string autor, int ano, string disciplina) 
            : base (titulo, autor, ano)
        {
            Disciplina = disciplina;
        }

        public override void ExibirStatus()
        {
            base.ExibirStatus();
            Console.WriteLine($"→ Livro Didático de {Disciplina}");
        }
    }
}
