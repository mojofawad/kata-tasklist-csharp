using System;
using NUnit.Framework;

namespace Tasks.Tests;

[TestFixture]
public class TaskDeadlineTests
{
    [Test]
    public void NewTask_ShouldHaveNoDeadline()
    {
        // Arrange and Act
        var task = new Task(1, "this task can be finished whenever");

        // Assert
        Assert.IsNull(task.Deadline);
    }

    [Test]
    public void SetDeadline_ShouldUpdateDeadline()
    {
        // Arrange
        var task = new Task(1, "this task will have a deadline");
        var expectedDate = new DateOnly(2025, 4, 18);

        // Act
        task.SetDeadline(expectedDate);

        // Assert
        Assert.AreEqual(expectedDate, task.Deadline);
    }

    [Test]
    public void SetDeadline_CanBeCalledMultipleTimes_UpdatesDeadline()
    {
        // Arrange
        var task = new Task(1, "this task has a deadline that was changed");
        var originalDeadLine = new DateOnly(2025, 12, 1);
        var newDeadline = new DateOnly(2025, 3, 12);
        var expectedDeadline = newDeadline;

        // Act
        task.SetDeadline(originalDeadLine);
        task.SetDeadline(newDeadline);

        // Assert
        Assert.AreEqual(expectedDeadline, task.Deadline);
        Assert.AreNotEqual(originalDeadLine, task.Deadline);
    }
}