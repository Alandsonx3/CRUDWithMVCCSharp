namespace Programa
{

    public class ModelProduto
    {
        string? Descricao { get; set; }
        string? Categoria { get; set; }
        int Quantidade { get; set; }
        decimal Preco { get; set; }


        public ModelProduto(string desc, string categ, int quant, decimal preco)
        {
            Descricao = desc;
            Categoria = categ;
            Quantidade = quant;
            Preco = preco;

            RepositoryProduto.Produtos.Add(this);
        }

        public static List<Produtos> ListarID(int index)
        {
            return RepositoryProduto.Produtos[index];
        }
        public static void Alterar(int index, string desc, string categ, int quant, decimal preco)
        {
            RepositoryProduto.Produto[index].Descricao = desc;
            RepositoryProduto.Produto[index].Categoria = categ;
            RepositoryProduto.Produto[index].Quantidade = quant;
            RepositoryProduto.Produto[index].Preco = preco;

        }

        public static void Deletar(int index)
        {
            RepositoryProduto.Produto.RemoveAt(index);
        }
    }
}