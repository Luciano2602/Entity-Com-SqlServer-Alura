namespace Alura.Loja.Testes.ConsoleApp
{
    internal class Compra
    {
      
        public int Id { get; set; }
        public double Preco { get; internal set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; internal set; }
        public int Quantidade { get; internal set; }
    }
}