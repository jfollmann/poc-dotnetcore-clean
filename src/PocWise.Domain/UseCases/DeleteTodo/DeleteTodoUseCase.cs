using PocWise.Domain.Repositories;

namespace PocWise.Domain.UseCases.DeleteTodo
{
  public class DeleteTodoUseCase : IDeleteTodoUseCase
  {
    private readonly ITodoRepository repository;

    public DeleteTodoUseCase(ITodoRepository repository)
    {
      this.repository = repository;
    }

    public void Handler(string id)
    {
      this.repository.Delete(id);
    }
  }
}