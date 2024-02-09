namespace BowlingScoreTesting;

using BowlingScoreApp;

[TestFixture]
public class BowlingTests
{
    Bowling bowling;

    [SetUp]
    public void Setup()
    {
        bowling = new Bowling();
    }

    [Test, TestCaseSource(typeof(TestData), nameof(TestData.CalculateRunningScoreTestCases))]
    public void CalculateRunningScore(int[] Rolls, int ExpectedResult)
    {
        Assert.That(bowling.CalculateRunningScore(new List<int>(Rolls)), Is.EqualTo(ExpectedResult));
    }
}
