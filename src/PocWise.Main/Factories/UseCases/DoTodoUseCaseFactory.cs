using PocWise.Domain.UseCases.DoTodo;
using PocWise.Main.Factories.Repositories;

namespace PocWise.Main.Factories.UseCases
{
  public static class DoTodoUseCaseFactory
  {
    public static DoTodoUseCase Make()
    {
      var repository = TodoRepositoryFactory.Make();
      return new DoTodoUseCase(repository);
    }
  }
}