namespace BowlingScoreApp;

public class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            List<int> Rolls = args[0].Split(',').Select(int.Parse).ToList();
            Bowling BowlingGame = new();

            if (args.ElementAtOrDefault(1) != null && args[1] == "verbose")
            {
                Console.WriteLine("Rolls: " + string.Join(", ", Rolls));
                int TotalScore = BowlingGame.CalculateRunningScore(Rolls);
                Console.WriteLine("Total score: " + TotalScore);
            }
            else
            {
                int TotalScore = BowlingGame.CalculateRunningScore(Rolls);
                Console.WriteLine(TotalScore);
            }
        }
    }
}
