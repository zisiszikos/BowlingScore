namespace BowlingScoreApp
{
    /// <summary>
    /// A Bowling game Frame (a single turn by a Bowler)
    /// </summary>
    public class Frame : IFrame
    {
        public int Roll1 { get; set; } = 0;
        public int Roll2 { get; set; } = 0;
        public int SpareBonus { get; set; } = 0;
        public int StrikeBonus { get; set; } = 0;
        public bool IsBonus { get; set; } = false;

        public Frame()
        {
        }

        public Frame(int rol1, int rol2)
        {
            Roll1 = rol1;
            Roll2 = rol2;
        }

        public bool IsSpare()
        {
            return Roll1 != 10 && Roll1 + Roll2 == 10;
        }

        public bool IsStrike()
        {
            return Roll1 == 10;
        }

        public int TotalScore()
        {
            return Roll1 + Roll2 + SpareBonus + StrikeBonus;
        }
    }
}
