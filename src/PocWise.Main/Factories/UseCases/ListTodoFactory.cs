using PocWise.Domain.UseCases.ListTodo;
using PocWise.Main.Factories.Repositories;

namespace PocWise.Main.Factories.UseCases
{
  public class ListTodoFactory
  {
    public static ListTodoUseCase Make()
    {
      var repository = TodoRepositoryFactory.Make();
      return new ListTodoUseCase(repository);
    }
  }
}