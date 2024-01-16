using Moq;
using PocWise.Domain.Repositories;
using PocWise.Domain.Entities;
using PocWise.Domain.UseCases.CreateTodo;

namespace PocWise.Domain.Tests.UseCases.CreateTodo
{
  public class CreateTodoTests
  {
    private readonly Todo args = new("1", "Sample");
    private readonly Mock<ITodoRepository> repositoryMock;
    private readonly CreateTodoUseCase useCase;

    public CreateTodoTests()
    {
      this.repositoryMock = new Mock<ITodoRepository>();
      this.useCase = new(this.repositoryMock.Object);
    }

    [Fact(DisplayName = "Should Create a Todo")]
    public void ShouldCreateATodo()
    {
      this.useCase.Handler(this.args);

      this.repositoryMock.Verify(item => item.Create(this.args), Times.Once());
    }

    [Fact(DisplayName = "Should throw if Repository Throws")]
    public void ShouldThrowIfRepositoryThrows()
    {
      this.repositoryMock.Setup(item => item.Create(It.IsAny<Todo>())).Throws(new Exception("Any Error"));

      Assert.Throws<Exception>(() => this.useCase.Handler(this.args));
      this.repositoryMock.Verify(item => item.Create(this.args), Times.Once());
    }
  }
}