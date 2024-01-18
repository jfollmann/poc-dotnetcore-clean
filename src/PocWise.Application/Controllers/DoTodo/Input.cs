namespace PocWise.Application.Controllers.DoTodo
{
  public record Input(string id)
  {
    public string Id { get; set; } = id;
  }
}