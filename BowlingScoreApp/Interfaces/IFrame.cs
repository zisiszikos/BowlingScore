namespace BowlingScoreApp;

/// <summary>
/// A Bowling game Frame Interface (a single turn by a Bowler)
/// </summary>
public interface IFrame
{
    public int Roll1 { get; set; }
    public int Roll2 { get; set; }
    public int SpareBonus { get; set; }
    public int StrikeBonus { get; set; }
    public bool IsBonus { get; set; }
    public bool IsSpare();
    public bool IsStrike();
    public int TotalScore();
}
