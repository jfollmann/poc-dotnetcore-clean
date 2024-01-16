using PocWise.Domain.Entities;
using PocWise.Domain.UseCases.CreateTodo;
using PocWise.Domain.UseCases.DeleteTodo;
using PocWise.Domain.UseCases.DoTodo;
using PocWise.Domain.UseCases.ListTodo;
using PocWise.Main.Factories.UseCases;

namespace PocWise.Main;

class Program
{
  static void Main(string[] args)
  {
    CreateTodoUseCase createTodoUseCase = CreateTodoFactory.Make();
    DeleteTodoUseCase deleteTodoUseCase = DeleteTodoFactory.Make();
    ListTodoUseCase listTodoUseCase = ListTodoFactory.Make();
    DoTodoUseCase doTodoUseCase = DoTodoFactory.Make();

    createTodoUseCase.Handler(new Todo("6", "Sample Todo 6"));
    deleteTodoUseCase.Handler("1");
    doTodoUseCase.Handler("2");
    doTodoUseCase.Handler("6");

    var allTodos = listTodoUseCase.Handler();

    allTodos.ForEach(item => Console.WriteLine("{0} | {1} | {2}", item.Id, item.Title, item.Done));
  }
}
