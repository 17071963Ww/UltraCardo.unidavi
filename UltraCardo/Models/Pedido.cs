namespace UltraCardo.API.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;

        public List<Produto> Produtos { get; set; } = new();

        public decimal ValorTotal => Produtos.Sum(p => p.Preco);
    }
}
