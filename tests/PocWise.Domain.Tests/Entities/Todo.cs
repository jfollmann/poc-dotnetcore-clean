using PocWise.Domain.Entities;
namespace PocWise.Domain.Tests;

public class TodoTests
{
  [Fact(DisplayName = "Should Create a Todo Instance")]
  public void ShouldCreateATodo()
  {
    Todo target = new("1", "Sample");

    Assert.Equal("1", target.Id);
    Assert.Equal("Sample", target.Title);
    Assert.False(target.Done);
  }

  [Fact(DisplayName = "Should Create a Done Todo Instance")]
  public void ShouldCreateADoneTodo()
  {
    Todo target = new("1", "Sample", true);

    Assert.Equal("1", target.Id);
    Assert.Equal("Sample", target.Title);
    Assert.True(target.Done);
  }
}