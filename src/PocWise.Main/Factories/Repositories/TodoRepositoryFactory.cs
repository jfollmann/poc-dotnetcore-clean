using PocWise.Domain.Repositories;
using PocWise.Infra;

namespace PocWise.Main.Factories.Repositories
{
  public static class TodoRepositoryFactory
  {
    private static ITodoRepository? Instance { get; set; }

    public static ITodoRepository Make()
    {
      if (Instance == null)
      {
        Instance = new TodoMemoryRepository();
      }

      return Instance;
    }
  }
}