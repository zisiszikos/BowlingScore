namespace BowlingScoreApp;

/// <summary>
/// A Bowling game Interface
/// </summary>
public interface IGame
{
    int CalculateRunningScore(List<int> Rolls);
}
