using TournamentWinner;

namespace Tests;

[TestClass]
public class TournamentWinnerTests
{
    [TestMethod]
    public void TournamentWinner_DefaultCase_Python()
    {
        // Arrange
        List<List<string>> competitions = new List<List<string>>
        {
            new List<string> { "HTML", "C#" },
            new List<string> { "C#", "Python" },
            new List<string> { "Python", "HTML" }
        };
        List<int> results = new List<int> { 0, 0, 1 };
        string expected = "Python";

        // Act
        var actual = new TournamentWinnerIssue().TournamentWinner(competitions, results);

        // Assert
        Assert.IsTrue(expected == actual);
    }
}
