namespace BowlingScoreApp;

/// <summary>
/// A cli application that calculates the running score of a Bowling game
/// </summary>
public static class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            List<int> Rolls = args[0].Split(',').Select(int.Parse).ToList();
            Game BowlingGame = new();
            int TotalScore = BowlingGame.CalculateRunningScore(Rolls);

            if (args.ElementAtOrDefault(1) != null && args[1] == "verbose")
            {
                Console.WriteLine("Rolls: " + string.Join(", ", Rolls));
                Console.WriteLine("Total score: " + TotalScore);
            }
            else
            {
                Console.WriteLine(TotalScore);
            }
        }
    }
}
