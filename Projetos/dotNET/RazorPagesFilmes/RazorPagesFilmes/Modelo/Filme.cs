using System.ComponentModel.DataAnnotations;

namespace RazorPagesFilmes.Modelo
{
    public class Filme
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime DataLancameto { get; set; }
        public string Genero { get; set; } = string.Empty;
        public decimal preco { get; set; } 
    }
}
