using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Produto
{
  public class ControllerProduto
  {
    public static void Creat(string des, string cat, float qtd)
    {
      ModelProduto.Creat(des, cat, qtd);
    }
    public static List<ModelProduto> Read()
    {
      return ModelProduto.Read();
    }
    public static void Update(int ind, string des, string cat, float qtd)
    {
      ModelProduto.Update(ind, des, cat, qtd);
    }
    public static void Delete(int ind)
    {
      ModelProduto.Delete(ind);
    }
  
  }
}