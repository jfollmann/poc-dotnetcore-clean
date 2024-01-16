using Moq;
using PocWise.Domain.Repositories;
using PocWise.Domain.UseCases.ListTodo;

namespace PocWise.Domain.Tests.UseCases.CreateTodo
{
  public class ListTodoTests
  {
    private readonly Mock<ITodoRepository> repositoryMock;
    private readonly ListTodoUseCase useCase;

    public ListTodoTests()
    {
      this.repositoryMock = new Mock<ITodoRepository>();
      this.useCase = new(this.repositoryMock.Object);
    }

    [Fact(DisplayName = "Should list todos")]
    public void ShouldCreateATodo()
    {
      this.useCase.Handler();

      this.repositoryMock.Verify(item => item.List(), Times.Once());
    }

    [Fact(DisplayName = "Should throw if Repository Throws")]
    public void ShouldThrowIfRepositoryThrows()
    {
      this.repositoryMock.Setup(item => item.List()).Throws(new Exception("Any Error"));

      Assert.Throws<Exception>(() => this.useCase.Handler());
      this.repositoryMock.Verify(item => item.List(), Times.Once());
    }
  }
}