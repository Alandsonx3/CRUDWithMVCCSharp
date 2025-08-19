using ToDo.Repository;

namespace ToDo.Modal
{
  public class ToDoModal
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public string? Status { get; set; }


    // Instantiating and creating a new item in the Tasks repository based on the data found;
    public static void Create(string title, string desc, DateTime date, string status)
    {
      var NewTask = new ToDoModal
      {
        Id = MyRepository.Tarefa.Count + 1,
        Title = title,
        Description = desc,
        Date = date,
        Status = status
      };

      MyRepository.Tarefa.Add(NewTask);
    }

    // Get reference from the Tasks repository
    public static List<ToDoModal> Read()
    {
      return MyRepository.Tarefa;
    }

    // Update values from Tasks repository with id reference
    public static void Update(int Id, string title, string desc, DateTime date, string status)
    {
      MyRepository.Tarefa[Id].Title = title;
      MyRepository.Tarefa[Id].Description = desc;
      MyRepository.Tarefa[Id].Date = date;
      MyRepository.Tarefa[Id].Status = status;
    }

    // Remove item from Tasks repository with id reference
    public static void Delete(int Id)
    {
      MyRepository.Tarefa.RemoveAt(Id);
    }

  }
}