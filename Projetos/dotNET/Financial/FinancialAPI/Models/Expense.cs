namespace FinancialAPI.Models {
    public class Expense
    {
        public int Id { get; set;}
        public string Descricao { get; set;}
        public decimal Valor { get; set;}
        public DateTime Data { get; set;}
    }
}