namespace BibliotecaApp
{
    public class Livro
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int Ano { get; private set; }
        public bool Disponivel { get; private set; } = true;

        public bool Emprestado { get; private set; } = false;

        // construtor da classe

        protected void TornarIndisponivel()
        {
            Disponivel = false;
        }

        protected void TornarEmprestado()
        {
            Emprestado = true;
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
                Emprestado = true;
            }
            else
            {
                Console.WriteLine($"O Livro \"{Titulo}\" já está emprestado.");
            }


        }

        public void Devolver()
        {
            if (Emprestado)
            {
                Disponivel = true;
                Emprestado = false;
            }
        }

        public virtual void ExibirStatus() //virtual para que possa ser sobrescrito
        {
            string status = Disponivel ? "Disponível" : "Emprestado";
            Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Ano: {Ano} - {status}");
        }

    }

}
