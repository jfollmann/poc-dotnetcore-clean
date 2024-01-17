using PocWise.Domain.UseCases.CreateTodo;
using PocWise.Main.Factories.Repositories;

namespace PocWise.Main.Factories.UseCases
{
  public class CreateTodoUseCaseFactory
  {
    public static CreateTodoUseCase Make()
    {
      var repository = TodoRepositoryFactory.Make();
      return new CreateTodoUseCase(repository);
    }
  }
}