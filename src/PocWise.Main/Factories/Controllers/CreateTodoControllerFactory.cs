using PocWise.Application.Controllers.CreateTodo;
using PocWise.Main.Factories.UseCases;

namespace PocWise.Main.Factories.Controllers
{
  public class CreateTodoControllerFactory
  {
    public static CreateTodoController Make()
    {
      var useCase = CreateTodoUseCaseFactory.Make();
      return new CreateTodoController(useCase);
    }
  }
}