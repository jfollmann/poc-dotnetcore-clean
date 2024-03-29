using PocWise.Domain.UseCases.DeleteTodo;
using PocWise.Main.Factories.Repositories;

namespace PocWise.Main.Factories.UseCases
{
  public static class DeleteTodoUseCaseFactory
  {
    public static DeleteTodoUseCase Make()
    {
      var repository = TodoRepositoryFactory.Make();
      return new DeleteTodoUseCase(repository);
    }
  }
}