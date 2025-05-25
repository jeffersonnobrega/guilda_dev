
namespace BibliotecaApp
{
    public class LivroFiccao : Livro
    {
       public string Genero{ get; set; }

        public LivroFiccao(string titulo, string autor, int ano, string genero) : base(titulo, autor, ano)
        {
            Genero = genero;
        }

/*override — "Estou substituindo um método virtual"
Quando você herda uma classe e deseja modificar um método virtual, você usa override*/
        public override void ExibirStatus()
        {
            base.ExibirStatus();
            Console.WriteLine($"→ Gênero: {Genero}");
        }

        
    }
}