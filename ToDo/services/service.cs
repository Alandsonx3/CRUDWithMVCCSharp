using ToDo.Modal;
using ToDo.Repository;

namespace ToDo.Service
{
  public static class MyService
  {
    public static void Create(string title, string desc, DateTime date, string status)
    {
      bool titleValid = IsInputValid(title);
      bool stateValid = IsInputValid(status);


      if (titleValid && stateValid)
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
      bool titleValid = IsInputValid(title);
      bool stateValid = IsInputValid(status);


      if (titleValid && stateValid)
      {
        ToDoModal.Update(id, title, desc, date, status);
      }
    }
    public static void Delete(int id)
    {
      ToDoModal.Delete(id);
    }
    public static bool IsInputValid(string value)
    {
      bool validation = false;

      if (value != null || value != "")
      {
        validation = true;
      }
      else
      {
        Console.WriteLine("Favor insira algum valor valido");
      }
      return validation;
    }
  }

}