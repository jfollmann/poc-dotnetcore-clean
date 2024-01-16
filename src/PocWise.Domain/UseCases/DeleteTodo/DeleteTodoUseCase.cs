using PocWise.Domain.Repositories;

namespace PocWise.Domain.UseCases.DeleteTodo
{
  public class DeleteTodoUseCase(ITodoRepository repository) : IDeleteTodoUseCase
  {
    private readonly ITodoRepository repository = repository;

    public void Handler(string id)
    {
      this.repository.Delete(id);
    }
  }
}