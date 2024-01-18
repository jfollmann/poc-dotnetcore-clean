namespace PocWise.Application.Controllers.DeleteTodo
{
  public record Input(string id)
  {
    public string Id { get; set; } = id;
  }
}