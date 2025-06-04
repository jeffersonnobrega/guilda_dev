namespace BibliotecaApp.Interfaces
{
    public interface ILivro
    {
        string Titulo { get; set; }
        string Autor { get; set; }
        int Ano { get;}
        string Editora { get; set; }
        string Isbn {get; set;}
        string Genero { get; set; }
        string EstadoConservacao { get; set; }
        byte Nota { get; set; }
        bool Disponivel { get;}
        bool Emprestado { get;}

        string ObterNotasEmEstrelas();
        void Emprestar();
        void Devolver();
        void ExibirStatus();
    }
}