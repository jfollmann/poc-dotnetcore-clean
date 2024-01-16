using PocWise.Domain.Repositories;

namespace PocWise.Domain.UseCases.DoTodo
{
  public class DoTodoUseCase(ITodoRepository repository) : IDoTodo
  {
    private readonly ITodoRepository repository = repository;

    public void Handler(string id)
    {
      this.repository.Do(id);
    }
  }
}