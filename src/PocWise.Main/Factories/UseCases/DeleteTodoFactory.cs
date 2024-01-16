using PocWise.Domain.UseCases.DeleteTodo;
using PocWise.Main.Factories.Repositories;

namespace PocWise.Main.Factories.UseCases
{
  public class DeleteTodoFactory
  {
    public static DeleteTodoUseCase Make()
    {
      var repository = TodoRepositoryFactory.Make();
      return new DeleteTodoUseCase(repository);
    }
  }
}