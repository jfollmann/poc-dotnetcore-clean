using PocWise.Domain.Entities;
using PocWise.Domain.Repositories;

namespace PocWise.Domain.UseCases.ListTodo
{
  public class ListTodoUseCase : IListTodoUseCase
  {
    private readonly ITodoRepository repository;

    public ListTodoUseCase(ITodoRepository repository)
    {
      this.repository = repository;
    }

    public List<Todo> Handler()
    {
      return this.repository.List();
    }
  }
}