using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa
{
    public static class ViewProduto
    {
        public static void Cadastrar()
        {
            string? descricao, categoria;
            int quantidade;
            decimal precoCusto;

            Console.WriteLine("\n\t[1] - Cadastrar novo produto:\n");

            Console.Write("\tDigite a Descrição do produto: ");
            descricao = Console.ReadLine();

            Console.Write("\tInforme a Categoria do produto: ");
            categoria = Console.ReadLine();

            Console.Write("\tInforme a Quantidade que chegou: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("\tInforme o valor de aquisição: ");
            precoCusto = Console.ReadLine().Replace(".", ",");


            ModelProduto(descricao, categoria, quantidade, precoCusto);
        }
        public static void Editar()
        {
            string? descricao, categoria;
            int quantidade, indice;
            decimal precoCusto;

            Console.WriteLine("\n\t[2] - Editar produto:\n");

            Console.Write("\tInforme o (ID) que deseja editar: ");
            indice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\tPeguei o produto {ModelProduto.ListarID(indice)}");

            Console.Write("\n\tDigite a Descrição do produto: ");
            descricao = Console.ReadLine();

            Console.Write("\tInforme a Categoria do produto: ");
            categoria = Console.ReadLine();

            Console.Write("\tInforme a Quantidade que chegou: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("\tInforme o valor de aquisição: ");
            precoCusto = Console.ReadLine().Replace(".", ",");

            ModelProduto.Alterar(indice, descricao, categoria, quantidade, precoCusto);
        }
        public static void Listar()
        {
            Listar<Produtos> Produtos = ModelProduto.Listar();

            Console.WriteLine("\n\t[3] - Listar produtos:\n");

            foreach (Produtos prod in produtos)
            {
                Console.WriteLine($"| {prod.Descricao} | {prod.Categoria} | {prod.Quantidade} | {prod.PrecoCusto} |");
            }
        }
        public static void Excluir()
        {
            int indice;

            Console.WriteLine("\n\t[4] - Excluir produto:\n");

            Console.Write("\tInforme o (ID) do produto que deseja Excluir: ");
            indice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\tExcluido com sucesso [{ModelProduto.ListarID(indice)}]");
            ModelProduto.Deletar(indice);
        }
    }
}