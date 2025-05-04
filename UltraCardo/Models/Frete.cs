namespace UltraCardo.API.Models
{
    public class Frete
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public decimal Valor { get; set; }

        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
