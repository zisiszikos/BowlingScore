namespace BowlingScoreApp;

public class Bowling : IBowling
{
    public int CalculateRunningScore(List<int> Rolls)
    {
        List<IFrame> FramesList = [];

        while (Rolls.Count > 0)
        {
            IFrame NextFrame = new Frame() { Roll1 = Rolls[0] };
            Rolls.RemoveAt(0);

            if (FramesList.Count >= 10) // Is one of bonus rolls
            {
                NextFrame.IsBonus = true;
            }
            else // Is one of regular frame rolls
            {
                if (NextFrame.Roll1 < 10) // Not a strike
                {
                    if (Rolls.Count > 0) // No second roll yet
                    {
                        NextFrame.Roll2 = Rolls[0];
                        Rolls.RemoveAt(0);
                    }
                }
            }

            FramesList.Add(NextFrame);

            if (FramesList.Count > 1) // First frame doesn't require any checks
            {
                IFrame PreviousFrame = FramesList[^2];
                IFrame CurrentFrame = FramesList[^1];

                if (PreviousFrame.IsSpare())
                {
                    PreviousFrame.SpareBonus = CurrentFrame.Roll1;
                }

                if (PreviousFrame.IsStrike() && !PreviousFrame.IsBonus)
                {
                    PreviousFrame.StrikeBonus += CurrentFrame.Roll1 + CurrentFrame.Roll2;
                }

                if (FramesList.Count > 2)
                {
                    IFrame SecondPreviousFrame = FramesList[^3];

                    if (SecondPreviousFrame.IsStrike() && (PreviousFrame.IsStrike() || PreviousFrame.IsBonus))
                    {
                        SecondPreviousFrame.StrikeBonus += CurrentFrame.Roll1;
                    }
                }
            }
        }

        return FramesList.Aggregate(0, (int acc, IFrame frame) => frame.IsBonus ? acc : acc + frame.TotalScore());
    }
}
