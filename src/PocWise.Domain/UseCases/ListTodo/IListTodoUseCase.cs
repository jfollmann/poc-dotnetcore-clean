using PocWise.Domain.Entities;

namespace PocWise.Domain.UseCases.ListTodo
{
  public interface IListTodoUseCase
  {
    List<Todo> Handler();
  }
}