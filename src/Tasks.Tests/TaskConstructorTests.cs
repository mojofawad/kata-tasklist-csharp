using NUnit.Framework;

namespace Tasks.Tests;

[TestFixture]
public class TaskConstructorTests
{
    [Test]
    public void Constructor_ShouldSetId()
    {
        // Arrange and Act
        long expectedId = 42;
        var task = new Task(expectedId, "id is forty-two");
        
        // Assert
        Assert.AreEqual(expectedId, task.Id);
    }

    [Test]
    public void Constructor_ShouldSetDescription()
    {
        // Arrange and Act
        string expectedDescription = "this is a description";
        var task = new Task(1, expectedDescription);
        
        // Assert
        Assert.AreEqual(expectedDescription, task.Description);
    }

    [Test]
    public void Constructor_ShouldInitializeDoneToFalse()
    {
        // Arrange and Act
        var task = new Task(1, "this task is note done");
        
        // Assert
        Assert.IsFalse(task.Done);
    }
}