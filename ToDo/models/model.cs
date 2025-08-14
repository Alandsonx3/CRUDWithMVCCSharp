using ToDo.Repository;

namespace ToDo.Modal
{
  public static class ToDoModal
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime DateTime { get; set; }
    public string? Status { get; set; }


    // Instantiating and creating a new item in the Tasks repository based on the data found;
    public void Create(int id, string title, string desc, DateTime date, string status)
    {
      Repository.Task.Count + 1;
      Title = title;
      Description = desc;
      DateTime = date;
      Status = status;

      Repository.Task.Add(this);
    }

    // Get reference from the Tasks repository
    public List<Task> Read()
    {
      return Repository.Task;
    }

    // Update values from Tasks repository with id reference
    public void Update(int Id, string title, string desc, string date, string status)
    {
      Repository.Task[Id].Title = title;
      Repository.Task[Id].Description = desc;
      Repository.Task[Id].DateTime = date;
      Repository.Task[Id].Status = status;
    }

    // Remove item from Tasks repository with id reference
    public void Delete(int Id)
    {
      Repository.Task.RemoveAt(Id);
    }

  }
}