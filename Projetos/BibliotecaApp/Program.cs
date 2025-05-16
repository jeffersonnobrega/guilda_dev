using BibliotecaApp;

class Program
{
    static void Main()
    {

        List<Livro> livros = new List<Livro>
        {
            new LivroDidatico("Matemática Básica", "Carlos Silva", 2020, "Matemática"),
            new LivroFiccao("O Hobbit", "J.R.R. Tolkien", 1937, "Fantasia"),
            new Livro("Livro Genérico", "Autor Desconhecido", 2000),
            new LivroRaro("Dom Quixote", "Miguel de Cervantes", 1605, "Ruim"),
            new LivroRaro("A Divina Comédia", "Dante Alighieri", 1320, "Bom"),

        };

      

        livros[2].Emprestar();

        Console.WriteLine("📚 Livros atualmente disponíveis para empréstimo:");

        var livrosDisponiveis = livros.Where(l => l.Disponivel).ToList();

                /*Where(...): filtra a lista.

        l => l.Disponivel: expressão lambda que diz "me mostre só os livros cujo Disponivel é true".*/

        foreach (var livro in livrosDisponiveis)
        {
            livro.ExibirStatus();
        }

        livros[2].Devolver();

        Console.WriteLine("\n🔍 Digite o título do livro para buscar:");
        string busca = Console.ReadLine() ?? "";

        var resultadoBusca = livros.FirstOrDefault(l =>
            l.Titulo.Contains(busca, StringComparison.OrdinalIgnoreCase));

        if (resultadoBusca != null)
        {
            Console.WriteLine("\n📖 Resultado encontrado:");
            resultadoBusca.ExibirStatus();
        }
        else
        {
            Console.WriteLine("❌ Livro não encontrado.");
        }

        
        
        List<Livro> livrosEmprestados = livros.Where (l => !l.Disponivel).ToList ();
        //pegue os livros que não estão emprestados (Diponível = false), e gere uma nova lista (tolist) chamada livrosEmprestados
        livros = livros.Where(l => l.Disponivel).ToList();
        //agora sobrescreve a lista original apenas com os livros disponíveis.

        //Exibir livros disponíveis
        Console.WriteLine("Livros disponíveis para empréstimo:");

        foreach (var livro in livros){
            livro.ExibirStatus();
        }

        Console.WriteLine("Livros emprestados e indisponíveis no momento");
        if (livrosEmprestados.Count > 0) {
            foreach (var livro in livrosEmprestados){
                livro.ExibirStatus();
            }
        } else {
            Console.WriteLine("Nenhum livro emprestado no momento.");
        }



    }
}
