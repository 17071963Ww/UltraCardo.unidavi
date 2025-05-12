using System.Text.Json.Serialization;

namespace UltraCardo.API.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string ImagemUrl { get; set; } = string.Empty;
        public decimal Preco { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        public List<Frete> FretesDisponiveis { get; set; } = new();
    }
}
