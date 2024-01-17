using PocWise.Application.Controllers.DeleteTodo;
using PocWise.Main.Factories.UseCases;

namespace PocWise.Main.Factories.Controllers
{
  public class DeleteTodoControllerFactory
  {
    public static DeleteTodoController Make()
    {
      var useCase = DeleteTodoUseCaseFactory.Make();
      return new DeleteTodoController(useCase);
    }
  }
}