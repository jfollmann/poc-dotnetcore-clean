using PocWise.Domain.Repositories;

namespace PocWise.Domain.UseCases.DoTodo
{
  public class DoTodoUseCase : IDoTodo
  {
    private readonly ITodoRepository repository;
    public DoTodoUseCase(ITodoRepository repository)
    {
      this.repository = repository;
    }
    public void Handler(string id)
    {
      this.repository.Do(id);
    }
  }
}