using TournamentWinner;

List<List<string>> competitions = new List<List<string>>
{
    new List<string> { "HTML", "C#" },
    new List<string> { "C#", "Python" },
    new List<string> { "Python", "HTML" }
};
List<int> results = new List<int> { 0, 0, 1 };

var winner = new TournamentWinnerIssue().TournamentWinner(competitions, results);
Console.WriteLine(winner);

namespace TournamentWinner
{
    public class TournamentWinnerIssue
    {
        public string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            for (int i = 0; i < competitions.Count; i++)
            {
                var firstTeam = competitions[i][0];
                var secondTeam = competitions[i][1];

                string winner = results[i] == 0 ? secondTeam : firstTeam;

                if (winners.ContainsKey(winner))
                {
                    winners[winner] += 3;
                }
                else
                {
                    winners.Add(winner, 3);
                }
            }
            var winnerWithMaxPoints = winners.MaxBy(x => x.Value);
            return winnerWithMaxPoints.Key;
        }
    }
}