using PocWise.Application.Controllers.DoTodo;
using PocWise.Domain.UseCases.DoTodo;

namespace PocWise.Application.Controllers.DoTo
{
  public class DoTodoController(IDoTodoUseCase useCase)
  {
    private IDoTodoUseCase UseCase { get; set; } = useCase;

    public void Handle(Input input)
    {
      this.UseCase.Handler(input.Id);
    }
  }
}