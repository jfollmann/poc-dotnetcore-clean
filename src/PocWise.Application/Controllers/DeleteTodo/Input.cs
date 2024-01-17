namespace PocWise.Application.Controllers.DeleteTodo
{
  public class Input(string id)
  {
    public string Id { get; set; } = id;
  }
}