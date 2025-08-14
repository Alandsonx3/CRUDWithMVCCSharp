using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Produto
{
  public class Program
  {
    public static void Main()
    {
      int opcao;

      do
      {
        Console.Clear();
        Console.WriteLine("GESTÃO DE ESTOQUE\n");

        Console.WriteLine("=> 1 - Cadastrar Produto");
        Console.WriteLine("=> 2 - Listar Produtos");
        Console.WriteLine("=> 3 - Editar Produto");
        Console.WriteLine("=> 4 - Excluir Produto");
        Console.WriteLine("=> 5 - Sair");

        Console.Write("\nInforme a opção: ");
        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
          case 1:
            ViewProduto.Creat();
            break;
          case 2:
            ViewProduto.Read();
            break;
          case 3:
            ViewProduto.Update();
            break;
          case 4:
            ViewProduto.Delete();
            break;
          case 5:
            Console.WriteLine("\n\t[5] - Sair:\n");
            Console.ReadLine();
            break;
          default:
            Console.WriteLine("Opção Inválida\n");
            break;
        }

      } while (opcao != 5);

    }
  }
}