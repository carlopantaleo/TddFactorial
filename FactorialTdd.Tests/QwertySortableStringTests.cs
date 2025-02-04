using FluentAssertions;

namespace FactorialTdd.Tests;

public class QwertySortableStringTests
{
    [Fact]
    public void Should_ImplicitlyConvertFromString_When_AssignedFromAString()
    {
        // Arrange
        string normalString = "hello";

        // Act
        QwertySortableString sortableString = normalString;

        // Assert
        ((string)sortableString).Should().BeEquivalentTo(normalString);
    }

    [Fact]
    public void Should_ImplicitlyConvertToString_When_AssignedToAString()
    {
        // Arrange
        QwertySortableString sortableString = "world";

        // Act
        string normalString = sortableString;

        // Assert
        normalString.Should().BeEquivalentTo("world");
    }

    [Fact]
    public void Should_SortAccordingToQwertyOrder_When_ComparedWithAnotherQwertySortableString()
    {
        // Arrange
        QwertySortableString string1 = "qaz";
        QwertySortableString string2 = "wsx";
        QwertySortableString string3 = "edc";

        // Act
        var result = new List<QwertySortableString> { string3, string1, string2 }
            .OrderBy(s => s)
            .ToList();

        // Assert
        result.Should().ContainInOrder(string1, string2, string3);
    }
}
