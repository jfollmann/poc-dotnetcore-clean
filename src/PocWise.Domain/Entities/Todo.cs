namespace PocWise.Domain.Entities
{
  public class Todo(string Id, string Title, bool Done = false)
  {
    public string Id { get; set; } = Id;
    public string Title { get; set; } = Title;
    public bool Done { get; set; } = Done;
  }
}