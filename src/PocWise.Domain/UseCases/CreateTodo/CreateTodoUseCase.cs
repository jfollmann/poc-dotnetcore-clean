using PocWise.Domain.Entities;
using PocWise.Domain.Repositories;

namespace PocWise.Domain.UseCases.CreateTodo
{
  public class CreateTodoUseCase : ICreateTodoUseCase
  {
    private readonly ITodoRepository repository;

    public CreateTodoUseCase(ITodoRepository repository)
    {
      this.repository = repository;
    }

    public void Handler(Todo todo)
    {
      this.repository.Create(todo);
    }
  }
}