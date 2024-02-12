namespace BowlingScoreApp;

/// <summary>
/// A Bowling game score calculator
/// </summary>
public class Game : IGame
{
    /// <summary>
    /// Calculates the running scrore at any point of a Bowling game.
    /// </summary>
    /// <param name="RollsList">A series of Bowling Rolls</param>
    /// <returns>The running score that derives from the given Rolls</returns>
    public int CalculateRunningScore(List<int> Rolls)
    {
        Stack<int> RollsList = new Stack<int>(Rolls.Reverse<int>());
        List<IFrame> FramesList = [];

        while (RollsList.Count > 0)
        {
            IFrame CurrentFrame = new Frame() { Roll1 = RollsList.Pop() };

            if (FramesList.Count >= 10) // Is one of bonus rolls
            {
                CurrentFrame.IsBonus = true;
            }
            else if (RollsList.Count > 0 && CurrentFrame.Roll1 < 10) // Has more rolls and Roll1 is not a strike
            {
                CurrentFrame.Roll2 = RollsList.Pop();
            }

            FramesList.Add(CurrentFrame);

            if (FramesList.Count > 1) // First frame doesn't require any checks
            {
                IFrame PreviousFrame = FramesList[^2];

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
