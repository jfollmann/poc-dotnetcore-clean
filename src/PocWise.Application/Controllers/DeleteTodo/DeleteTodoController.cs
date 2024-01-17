using PocWise.Domain.UseCases.DeleteTodo;

namespace PocWise.Application.Controllers.DeleteTodo
{
  public class DeleteTodoController(IDeleteTodoUseCase useCase)
  {
    private IDeleteTodoUseCase UseCase { get; set; } = useCase;

    public void Handle(Input input)
    {
      this.UseCase.Handler(input.Id);
    }
  }
}