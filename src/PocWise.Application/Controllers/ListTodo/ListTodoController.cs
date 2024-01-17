using PocWise.Domain.UseCases.ListTodo;

namespace PocWise.Application.Controllers.ListTodo
{
  public class ListTodoController(IListTodoUseCase useCase)
  {
    private IListTodoUseCase UseCase { get; set; } = useCase;

    public List<Output> Handle()
    {
      var todos = this.UseCase.Handler();
      return todos.Select(item => new Output(item.Id, item.Title, item.Done)).ToList();
    }
  }
}