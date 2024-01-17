using PocWise.Application.Controllers.CreateTodo;
using PocWise.Application.Controllers.DeleteTodo;
using PocWise.Application.Controllers.DoTo;
using PocWise.Application.Controllers.ListTodo;
using PocWise.Main.Factories.Controllers;
using CreateTodoInput = PocWise.Application.Controllers.CreateTodo.Input;
using DeleteTodoInput = PocWise.Application.Controllers.DeleteTodo.Input;
using DoTodoInput = PocWise.Application.Controllers.DoTodo.Input;

namespace PocWise.Main;

class Program
{
  static void Main(string[] args)
  {
    CreateTodoController createTodoController = CreateTodoControllerFactory.Make();
    DeleteTodoController deleteTodoController = DeleteTodoControllerFactory.Make();
    DoTodoController doTodoController = DoTodoControllerFactory.Make();
    ListTodoController listTodoController = ListTodoControllerFactory.Make();
    
    createTodoController.Handle(new CreateTodoInput("8", "Sample Todo 8", true));
    createTodoController.Handle(new CreateTodoInput("9", "Sample Todo 9", null));
    deleteTodoController.Handle(new DeleteTodoInput("1"));
    doTodoController.Handle(new DoTodoInput("2"));
    doTodoController.Handle(new DoTodoInput("3"));

    var allTodos = listTodoController.Handle();
    allTodos.ForEach(item => Console.WriteLine("{0} | {1} | {2}", item.Id, item.Title, item.Done));
  }
}
