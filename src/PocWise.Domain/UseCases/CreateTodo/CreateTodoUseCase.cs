using PocWise.Domain.Entities;
using PocWise.Domain.Repositories;

namespace PocWise.Domain.UseCases.CreateTodo
{
  public class CreateTodoUseCase(ITodoRepository repository) : ICreateTodoUseCase
  {
    private readonly ITodoRepository repository = repository;

    public void Handler(Todo todo)
    {
      this.repository.Create(todo);
    }
  }
}