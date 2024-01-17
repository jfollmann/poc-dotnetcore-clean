namespace PocWise.Application.Controllers.ListTodo
{
  public class Output(string id, string title, bool done)
  {
    public string Id { get; set; } = id;
    public string Title { get; set; } = title;
    public bool Done { get; set; } = done;
  }
}