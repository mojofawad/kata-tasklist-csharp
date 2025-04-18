using NUnit.Framework;

namespace Tasks.Tests;

[TestFixture]
public class TaskTests
{
    [Test]
    public void NewTask_ShouldBeNotDone()
    {
        // Arrange and Act
        var task = new Task(1, "Test task");
        
        // Assert
        Assert.IsFalse(task.Done);
    }

    [Test]
    public void MarkDone_ShouldSetDoneToTrue()
    {
        // Arrange
        var task = new Task(1, "Test task");
        
        // Act
        task.MarkDone();
        
        // Assert
        Assert.IsTrue(task.Done);
    }

    [Test]
    public void MarkNotDone_ShouldSetDoneToFalse()
    {
        // Arrange
        var task = new Task(1, "Test task");
        task.MarkDone();
        
        // Act
        task.MarkNotDone();
        
        // Assert
        Assert.IsFalse(task.Done);
    }
}