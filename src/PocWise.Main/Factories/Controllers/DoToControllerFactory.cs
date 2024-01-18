using PocWise.Application.Controllers.DoTo;
using PocWise.Main.Factories.UseCases;

namespace PocWise.Main.Factories.Controllers
{
  public static class DoTodoControllerFactory
  {
    public static DoTodoController Make()
    {
      var useCase = DoTodoUseCaseFactory.Make();
      return new DoTodoController(useCase);
    }
  }
}