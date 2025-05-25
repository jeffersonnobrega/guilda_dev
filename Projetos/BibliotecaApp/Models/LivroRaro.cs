namespace BibliotecaApp
{
    public class LivroRaro : Livro
    {
       // public string EstadoConservacao { get; set; }



        public LivroRaro(string titulo, string autor, int ano, string estadoConservacao)
            : base(titulo, autor, ano,estadoConservacao)
        {
            
            if (estadoConservacao.Equals("ruim", StringComparison.OrdinalIgnoreCase))
            {
                TornarIndisponivel(); // Já define Disponivel = false

            }
        }

        public override void Emprestar()
        {
            if (EstadoConservacao.Equals("ruim", StringComparison.OrdinalIgnoreCase))
            {

                Console.WriteLine($"O livro raro \"{Titulo}\" está permanentemente indisponível devido ao estado de conservação: \"{EstadoConservacao}\"");
            }
            else
            {
                base.Emprestar();
            }
        }
        public override void ExibirStatus()
        {
            string status;
            if (!Disponivel && !Emprestado)
            {
                status = $"Indisponível (estado de Conservação: {EstadoConservacao})";
            }
            else
            {
                status = Disponivel ? "Disponível" : "Emprestado";
            }
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {Ano} - {status}");
            Console.WriteLine($"[Raro] estado de Conservação: {EstadoConservacao}");
        }
    }
}
