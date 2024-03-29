using PocWise.Domain.UseCases.ListTodo;
using PocWise.Main.Factories.Repositories;

namespace PocWise.Main.Factories.UseCases
{
  public static class ListTodoUseCaseFactory
  {
    public static ListTodoUseCase Make()
    {
      var repository = TodoRepositoryFactory.Make();
      return new ListTodoUseCase(repository);
    }
  }
}