using PocWise.Domain.Entities;

namespace PocWise.Domain.UseCases.CreateTodo
{
  public interface ICreateTodoUseCase
  {
    void Handler(Todo todo);
  }
}