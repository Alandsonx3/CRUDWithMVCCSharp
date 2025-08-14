using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Produto
{
  public class ViewProduto
  {
    public static void Creat()
    {
      Console.Clear();
      Console.WriteLine("GESTÃO DE ESTOQUE => CADASTRAR PRODUTO ##\n");

      Console.Write("Digite a descrição do produto: ");
      string? desc = Console.ReadLine();

      Console.Write("Informe a categoria do produto: ");
      string? categ = Console.ReadLine();

      Console.Write("Informe a quantidade: ");
      float quant = Convert.ToInt32(Console.ReadLine());

      ControllerProduto.Creat(desc, categ, quant);
    }
    public static void Read()
    {
      Console.Clear();
      Console.WriteLine("GESTÃO DE ESTOQUE => LISTAR PRODUTOS ##\n");

      List<ModelProduto> Produtos = ControllerProduto.Read();

      Console.WriteLine(" DESCRIÇÃO\t | CATEGORIA\t | QUANTIDADE");
      foreach (ModelProduto Produto in Produtos)
      {
        Console.WriteLine($" {Produto.Descricao}\t | {Produto.Categoria}\t | {Produto.Quantidade}");
      }
      Console.ReadLine();

    }
    public static void Update()
    {
      Console.Clear();
      Console.WriteLine("GESTÃO DE ESTOQUE => EDITAR PRODUTO ##\n");

      Console.WriteLine("Informe o código do produto a ser alterado: ");
      int indice = Convert.ToInt32(Console.ReadLine());
      Console.Write("Digite a nova descrição do produto: ");
      string? desc = Console.ReadLine();

      Console.Write("Informe a nova categoria do produto: ");
      string? categ = Console.ReadLine();

      Console.Write("Informe a nova quantidade: ");
      float quant = Convert.ToInt32(Console.ReadLine());

      ControllerProduto.Update(indice, desc, categ, quant);
    }
    public static void Delete()
    {
      Console.Clear();
      Console.WriteLine("GESTÃO DE ESTOQUE => EXCLUIR PRODUTO ##\n");

      Console.WriteLine("Informe o código do produto a ser excluído: ");
      int indice = Convert.ToInt32(Console.ReadLine());

      ControllerProduto.Delete(indice);
    }
  }
}