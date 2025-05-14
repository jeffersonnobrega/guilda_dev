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
    }
}
