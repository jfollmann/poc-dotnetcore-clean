using PocWise.Application.Controllers.ListTodo;
using PocWise.Main.Factories.UseCases;

namespace PocWise.Main.Factories.Controllers
{
  public class ListTodoControllerFactory
  {
    public static ListTodoController Make()
    {
      var useCase = ListTodoUseCaseFactory.Make();
      return new ListTodoController(useCase);
    }
  }
}