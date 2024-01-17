namespace PocWise.Application.Controllers.CreateTodo
{
  public class Input(string Id, string Title, bool? Done)
  {
    public string Id { get; set; } = Id;
    public string Title { get; set; } = Title;
    public bool? Done { get; set; } = Done;
  }
}