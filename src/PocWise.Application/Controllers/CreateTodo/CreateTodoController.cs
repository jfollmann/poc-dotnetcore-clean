using PocWise.Domain.Entities;
using PocWise.Domain.UseCases.CreateTodo;

namespace PocWise.Application.Controllers.CreateTodo
{
  public class CreateTodoController(ICreateTodoUseCase useCase)
  {
    private ICreateTodoUseCase UseCase { get; set; } = useCase;

    public void Handle(Input input)
    {
      Todo todo = new(input.Id, input.Title, input.Done ?? false);
      this.UseCase.Handler(todo);
    }
  }
}