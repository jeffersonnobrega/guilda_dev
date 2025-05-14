using System;
using System.Collections.Generic;


class Program
{
    static void Main(){
        var livro1 = new Livro("1984", "George Orwell", 1949);
        var livro2 = new Livro("A Crônica de Sangue e Fé", "Jefferson Nóbrega", 2015);
        var livro3 = new Livro("A Revolução dos Bichos", "George Orwell", 1945);

        livro2.Emprestar();

        List<Livro> biblioteca = new List<Livro>{livro1, livro2, livro3};

        foreach (var livro in biblioteca)
        {
            livro.ExibirStatus();
        }
    }
}