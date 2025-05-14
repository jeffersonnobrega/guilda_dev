namespace BibliotecaApp
{
    public class Livro
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int Ano { get; private set; }
        public bool Disponivel { get; private set; } = true;

        // construtor da classe

        protected void TornarIndisponivel()
        {
            Disponivel = false;
        }

        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }

        public virtual void Emprestar()
        {
            if (Disponivel)
            {
                Disponivel = false;
            }
            else
            {
                Console.WriteLine($"O Livro \"{Titulo}\" já está emprestado.");
            }


        }

        public void Devolver()
        {
            Disponivel = true;
        }

        public virtual void ExibirStatus() //virtual para que possa ser sobrescrito
        {
            string status = Disponivel ? "Disponível" : "Emprestado";
            Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Ano: {Ano} - {status}");
        }

    }

}
