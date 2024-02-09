namespace BowlingScoreApp;

public interface IFrame
{
    public int Roll1 { get; set; }
    public int Roll2 { get; set; }
    public int SpareBonus { get; set; }
    public int StrikeBonus { get; set; }
    public Boolean IsBonus { get; set; }
    public Boolean IsSpare();
    public Boolean IsStrike();
    public int TotalScore();
}
