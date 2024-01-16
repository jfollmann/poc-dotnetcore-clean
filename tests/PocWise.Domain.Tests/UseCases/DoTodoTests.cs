using Moq;
using PocWise.Domain.Repositories;
using PocWise.Domain.UseCases.DoTodo;

namespace PocWise.Domain.Tests.UseCases.CreateTodo
{
  public class DoTodoTests
  {
    private readonly string args = "1";
    private readonly Mock<ITodoRepository> repositoryMock;
    private readonly DoTodoUseCase useCase;

    public DoTodoTests()
    {
      this.repositoryMock = new Mock<ITodoRepository>();
      this.useCase = new(this.repositoryMock.Object);
    }

    [Fact(DisplayName = "Should set Todo to Done")]
    public void ShouldCreateATodo()
    {
      this.useCase.Handler(this.args);

      this.repositoryMock.Verify(item => item.Do(this.args), Times.Once());
    }

    [Fact(DisplayName = "Should throw if Repository Throws")]
    public void ShouldThrowIfRepositoryThrows()
    {
      this.repositoryMock.Setup(item => item.Do(It.IsAny<string>())).Throws(new Exception("Any Error"));

      Assert.Throws<Exception>(() => this.useCase.Handler(this.args));
      this.repositoryMock.Verify(item => item.Do(this.args), Times.Once());
    }
  }
}