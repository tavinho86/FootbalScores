namespace FootballScores
{
    public class Business
    {
        public int[] Calculate(List<int> teamA, List<int> teamB)
        {
            List<int> result = new List<int>();

            foreach (int goalsB in teamB)
            {
                int count = 0;

                foreach (int goalsA in teamA)
                {
                    if (goalsA <= goalsB)
                    {
                        count++;
                    }
                }

                result.Add(count);
            }

            return result.ToArray();
        }

        public int[] CalculateBetter(List<int> teamA, List<int> teamB)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> keyValueTeamA = new Dictionary<int, int>();

            int index = 0;
            foreach (int goalsA in teamA)
            {
                keyValueTeamA.Add(index, goalsA);

                index++;
            }

            foreach (int goalsB in teamB)
            {
                int count = keyValueTeamA.Count(goalsA => goalsA.Value <= goalsB);

                result.Add(count);
            }

            return result.ToArray();
        }
    }
}