namespace BowlingScoreTesting;

using BowlingScoreApp;

[TestFixture]
public class BowlingTests
{
    Game BowlingGame;

    [SetUp]
    public void Setup()
    {
        BowlingGame = new Game();
    }

    [Test, TestCaseSource(typeof(TestData), nameof(TestData.CalculateRunningScoreTestCases))]
    public void CalculateRunningScore(int[] Rolls, int ExpectedResult)
    {
        Assert.That(BowlingGame.CalculateRunningScore(new List<int>(Rolls)), Is.EqualTo(ExpectedResult));
    }
}
