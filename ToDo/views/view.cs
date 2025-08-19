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

      Console.Write("\nStatus atual: ");
      string? status = Console.ReadLine();

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
      int id = int.Parse(Console.ReadLine());

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
      int id = int.Parse(Console.ReadLine());
    }
  }
}