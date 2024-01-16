using PocWise.Domain.Entities;
using PocWise.Domain.Repositories;

namespace PocWise.Infra;

public class TodoMemoryRepository : ITodoRepository
{
  private readonly List<Todo> dbTodos;

  public TodoMemoryRepository()
  {
    this.dbTodos = new List<Todo>()
    {
      new("1", "Sample Todo 1"),
      new("2", "Sample Todo 2"),
      new("3", "Sample Todo 3"),
      new("4", "Sample Todo 4"),
      new("5", "Sample Todo 5"),
    };
  }

  private Todo? GetItem(string Id)
  {
    return this.dbTodos.SingleOrDefault((item) => item.Id == Id);
  }

  public void Create(Todo todo)
  {
    this.dbTodos.Add(todo);
  }

  public void Delete(string Id)
  {
    var item = this.GetItem(Id);
    if (item != null)
    {
      this.dbTodos.Remove(item);
    }
  }

  public void Do(string Id)
  {
    var item = this.GetItem(Id);
    if (item != null)
    {
      item.Done = true;
    }
  }

  public List<Todo> List()
  {
    return this.dbTodos;
  }
}
