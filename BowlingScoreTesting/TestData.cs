namespace BowlingScoreTesting;

public class TestData
{
    public static IEnumerable<TestCaseData> CalculateRunningScoreTestCases()
    {
        yield return new TestCaseData(new int[] { }, 0).SetName("No rolls");
        yield return new TestCaseData(new int[] { 2 }, 2).SetName("One simple roll");
        yield return new TestCaseData(new int[] { 2, 1 }, 3).SetName("Two simple rolls");
        yield return new TestCaseData(new int[] { 2, 2, 1 }, 5).SetName("Three simple rolls");
        yield return new TestCaseData(new int[] { 2, 2, 1, 5 }, 10).SetName("Four simple rolls");
        yield return new TestCaseData(new int[] { 2, 8, 1, 5 }, 17).SetName("Single spare");
        yield return new TestCaseData(new int[] { 2, 8, 3, 7, 4 }, 31).SetName("Two spare in a row");
        yield return new TestCaseData(new int[] { 10, 4, 5 }, 28).SetName("Single strike");
        yield return new TestCaseData(new int[] { 10, 10, 5, 3 }, 51).SetName("Strike followed by strike");
        yield return new TestCaseData(new int[] { 2, 8, 10, 3, 4 }, 44).SetName("Spare followed by strike");
        yield return new TestCaseData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 8, 3 }, 13).SetName("Spare at final frame");
        yield return new TestCaseData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 3, 5 }, 18).SetName("Strike at final frame");
        yield return new TestCaseData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 10, 3, 5 }, 41).SetName("Two Strikes at two final frames");
        yield return new TestCaseData(new int[] { 10, 7, 3, 9, 0, 10, 0, 8, 8, 2, 0, 6, 10, 10, 10, 8, 1 }, 167).SetName("General Case expecting 167");
        yield return new TestCaseData(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 150).SetName("All rolls are 5s");
        yield return new TestCaseData(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, 300).SetName("All rolls are strikes");
        yield return new TestCaseData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 10, 10, 10 }, 30).SetName("General Case illegal!!!");
    }
}
