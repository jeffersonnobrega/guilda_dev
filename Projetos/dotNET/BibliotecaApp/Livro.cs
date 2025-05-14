namespace BibliotecaApp;

public class Livro
{
    string Titulo { get; set; } = string.Empty;
    string Autor { get; set; } = string.Empty;
    int Ano { get;}
    public bool Disponivel { get; private set; } = true;

// construtor da classe

    public Livro(string titulo, string autor,int ano) {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }
        
    public void Emprestar () {
        if (Disponivel) {
            Disponivel = false;
        } else {
            Console.WriteLine($"O Livro \"{Titulo}\" já está emprestado.");
        }

        
    }

    public void Devolver () {
        Disponivel = true;
    }

    public void ExibirStatus(){
        string status = Disponivel ? "Disponível" : "Emprestado";
        Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Ano: {Ano} - {status}");
    }

}


