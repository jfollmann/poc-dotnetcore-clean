using PocWise.Domain.Entities;

namespace PocWise.Domain.Repositories
{
  public interface ITodoRepository
  {
    void Create(Todo todo);
    List<Todo> List();
    void Delete(string Id);
    void Do(string Id);
  }
}