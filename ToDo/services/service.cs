using ToDo.Modal;
using ToDo.Repository;

namespace ToDo.Service
{
  public static class MyService
  {
    public static void Create(string title, string desc, DateTime date, string status)
    {
      string titleValid = IsInputValid(title);
      if (titleValid == "invalido")
      {
        Console.Write("\nATENÇÃO: Título vazio!");
        Console.ReadLine();
      }

      string stateValid = IsInputValid(status);
      if (stateValid == "invalido")
      {
        Console.Write("ATENÇÃO: Status em branco!");
        Console.ReadLine();
      }


      if (titleValid == "ok" && stateValid == "ok")
      {
        ToDoModal.Create(title, desc, date, status);
      }

    }
    public static void Read()
    {
      List<ToDoModal> AllTarefas = ToDoModal.Read();

      foreach (var value in AllTarefas)
      {
        Console.WriteLine($"{value.Id} - {value.Title} - {value.Description} - {value.Date.ToString("dd/MM/yyyy 'às' HH:mm:ss")} [{value.Status}]");
      }
      Console.ReadLine();

    }
    public static void Update(int id, string title, string desc, DateTime date, string status)
    {
      string titleValid = IsInputValid(title);
      if (titleValid == "invalido")
      {
        Console.WriteLine("Título vazio!");
        Console.ReadLine();
      }

      string stateValid = IsInputValid(status);
      if (stateValid == "invalido")
      {
        Console.WriteLine("Status em branco!");
        Console.ReadLine();
      }

      if (titleValid == "ok" && stateValid == "ok")
      {
        ToDoModal.Update(id, title, desc, date, status);
      }
    }
    public static void Delete(int id)
    {
      ToDoModal.Delete(id);
    }
    public static string IsInputValid(string value)
    {
      string validation;

      if (value == "")
      {
        validation = "invalido";
      }
      else
      {
        validation = "ok";
      }
      return validation;
    }
  }

}