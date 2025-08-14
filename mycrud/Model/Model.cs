using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Produto
{
  public class ModelProduto
  {
      public string? Descricao { get; set; }
      public string? Categoria { get; set; }
      public float Quantidade { get; set; }

      public static void Creat(string desc, string categ, float quant)
      {
            var novo = new ModelProduto
            {
                Descricao = desc,
                Categoria = categ,
                Quantidade = quant
            };            

          Repository.Itens.Add(novo);
      }

      public static List<ModelProduto> Read()
      {
          return Repository.Itens;
      }

      public static void Update(int ind, string des, string cat, float qtd)
      {
          Repository.Itens[ind].Descricao = des;
          Repository.Itens[ind].Categoria = cat;
          Repository.Itens[ind].Quantidade = qtd;
      }

      public static void Delete(int ind) {
          Repository.Itens.RemoveAt(ind);
      }
    
  }
}