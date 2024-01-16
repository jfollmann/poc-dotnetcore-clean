using Moq;
using PocWise.Domain.Repositories;
using PocWise.Domain.UseCases.DeleteTodo;

namespace PocWise.Domain.Tests.UseCases.CreateTodo
{
  public class DeleteTodoTests
  {
    private readonly string args = "1";
    private readonly Mock<ITodoRepository> repositoryMock;
    private readonly DeleteTodoUseCase useCase;

    public DeleteTodoTests()
    {
      this.repositoryMock = new Mock<ITodoRepository>();
      this.useCase = new(this.repositoryMock.Object);
    }

    [Fact(DisplayName = "Should Delete a Todo")]
    public void ShouldCreateATodo()
    {
      this.useCase.Handler(this.args);

      this.repositoryMock.Verify(item => item.Delete(this.args), Times.Once());
    }

    [Fact(DisplayName = "Should throw if Repository Throws")]
    public void ShouldThrowIfRepositoryThrows()
    {
      this.repositoryMock.Setup(item => item.Delete(It.IsAny<string>())).Throws(new Exception("Any Error"));

      Assert.Throws<Exception>(() => this.useCase.Handler(this.args));
      this.repositoryMock.Verify(item => item.Delete(this.args), Times.Once());
    }
  }
}