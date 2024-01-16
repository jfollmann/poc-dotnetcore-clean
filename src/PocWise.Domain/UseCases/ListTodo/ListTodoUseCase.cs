using PocWise.Domain.Entities;
using PocWise.Domain.Repositories;

namespace PocWise.Domain.UseCases.ListTodo
{
  public class ListTodoUseCase(ITodoRepository repository) : IListTodoUseCase
  {
    private readonly ITodoRepository repository = repository;

    public List<Todo> Handler()
    {
      return this.repository.List();
    }
  }
}