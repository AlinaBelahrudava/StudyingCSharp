using System.Text.RegularExpressions;

namespace StudyingTasks.StringAnalysys
{
    public class StringAnalyzer
    {

        public string GetMaxUniqueSequence(string line)
        {
            string sequence = string.Empty;
            if (!string.IsNullOrEmpty(line))
            {
                string subsequence = string.Empty;
                for (int i = 0; i < line.Length; i++)
                {

                    if (!subsequence.Contains(line[i]))
                    {
                        subsequence += line[i];
                        if (subsequence.Length > sequence.Length)
                        {
                            sequence = subsequence;
                        }
                    }
                    else
                    {
                        int startIndex = line.IndexOf(line[i]);
                        line = line.Substring(startIndex + 1, line.Length - startIndex - 1);
                        subsequence = string.Empty;
                        i=-1;
                    }

                }
                Console.WriteLine("The longest sequence of unique symbols is: \"" + sequence + "\"");

            }
            else
            {
                Console.WriteLine("String is null or emty");
            }
            return sequence;
        }

        public string GetMaxSameLettersSequence(string line)
        {
            Regex regex = new Regex(@"([a-zA-Z])\1*");
            MatchCollection matches = regex.Matches(line);
            List<string> sequences = new();
            foreach (var m in matches)
            {
                sequences.Add(m.ToString());
            }
            return sequences.MaxBy(s => s.Length);
        }

        public string GetMaxSameDigitsSequence(string line)
        {
            Regex regex = new Regex(@"(\d)\1*");
            MatchCollection matches = regex.Matches(line);
            List<string> sequences = new();
            foreach (var m in matches)
            {
                sequences.Add(m.ToString());
            }
            return sequences.MaxBy(s => s.Length);
        }
    }
}
