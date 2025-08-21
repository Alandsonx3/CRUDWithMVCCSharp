using ToDo.View;

namespace ToDo.Main
{
  public class Program
  {
    public static void Main()
    {
      int opcao = 0;
      
      do
      {
        try
        {
          Console.Clear();
          Console.WriteLine("LISTA DE TAREFAS\n");

          Console.WriteLine("=> 1 - Nova Tarefa;");
          Console.WriteLine("=> 2 - Ver Tarefas;");
          Console.WriteLine("=> 3 - Editar Tarefa;");
          Console.WriteLine("=> 4 - Excluir Tarefa;");
          Console.WriteLine("=> 5 - Sair;");

          Console.Write("\nInforme a opção: ");
          opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
          {
            case 1:
              ToDoView.Create();
              break;
            case 2:
              ToDoView.Read();
              break;
            case 3:
              ToDoView.Update();
              break;
            case 4:
              ToDoView.Delete();
              break;
            case 5:
              Console.WriteLine("\n\t[5] - Sair?:\n");
              Console.ReadLine();
              break;
            default:
              Console.WriteLine("Opção Inválida\n");
              break;
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
          Console.Write("\nDigite 'Enter' e tente novamente!\n");
          Console.ReadLine();
        }
      } while (opcao != 5);

    }
  }
}