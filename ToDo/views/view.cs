using ToDo.Service;

namespace ToDo.View
{
  public static class ToDoView
  {
    public static void Create()
    {
      Console.Write("\nTítulo da nova tarefa: ");
      string? title = Console.ReadLine();

      Console.Write("\nDescrição da tarefa: ");
      string? descricao = Console.ReadLine();

      DateTime date = DateTime.Now; // Conferir funcionamento

      string status = "";
      Console.WriteLine("\nOpção de Status:\n");

      do
      {
        Console.WriteLine("[1] A iniciar");
        Console.WriteLine("[2] Em andamento");
        Console.WriteLine("[3] Concluído");
        Console.WriteLine("[4] Cancelado");
        
        Console.Write("Digite a opção: ");
        int statusCollect = Convert.ToInt32(Console.ReadLine());

        switch (statusCollect)
        {
          case 1:
            status = "A iniciar";
            break;
          case 2:
            status = "Em andamento";
            break;
          case 3:
            status = "Concluído";
            break;
          case 4:
            status = "Cancelado";
            break;
          default:
            Console.WriteLine("\nOpção inválida");
            Console.ReadLine();
            break;
        }
      } while (status == "");

      MyService.Create(title, descricao, date, status);
    }

    public static void Read()
    {
      Console.WriteLine("\n Listando todas as tarefas:\n");
      MyService.Read();
    }
    public static void Update()
    {
      Console.Write("Código da Tarefa a editar: ");
      int id = Convert.ToInt32(Console.ReadLine());

      Console.Write("\nNovo Título: ");
      string? title = Console.ReadLine();

      Console.Write("\nDescrição da tarefa: ");
      string? descricao = Console.ReadLine();

      DateTime date = DateTime.Now; // Conferir funcionamento

      Console.Write("\nStatus atual: ");
      string? status = Console.ReadLine();

      MyService.Update(id, title, descricao, date, status);
    }
    public static void Delete()
    {
      Console.Write("Código da Tarefa a excluir: ");
      int id = Convert.ToInt32(Console.ReadLine());

      MyService.Delete(id);
    }
  }
}