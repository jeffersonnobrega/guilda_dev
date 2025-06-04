using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using BibliotecaApp.Interfaces;

namespace BibliotecaApp.Models
{
    public class Livro : ILivro
    {
        private const int NotaMaxima = 5;
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int Ano { get; private set; }
        public string Editora { get; set; }
        public string Isbn { get; set; }
        public string Genero { get; set; }
        public string EstadoConservacao { get; set; }
        public byte Nota { get; set; }

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

        public Livro(string titulo, string autor, int ano, string estadoConservacao, int notaMaxima)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            EstadoConservacao = estadoConservacao;            

        }

        public string ObterNotasEmEstrelas()
        {
            
            int notaAtual = Math.Clamp((int)Nota, 0, NotaMaxima);

            string estrelasCheias = new string('★', notaAtual);
            //Cria uma string repetindo o caractere '★' o número de vezes indicado pela nota.
            string estrelasVazias = new string('☆', NotaMaxima - notaAtual);

            return estrelasCheias + estrelasVazias;
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
