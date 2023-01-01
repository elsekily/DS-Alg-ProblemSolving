using System.Text;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class Thek_thLexicographicalStringofAllHappyStringsofLengthn
    {
        private char[] letters = new char[] { 'a', 'b', 'c' };
        public string GetHappyString(int n, int k)
        {
            var results = new List<string>();
            BackTracking(n, results, new StringBuilder());
            return k - 1 < results.Count ? results[k - 1] : "";
        }
        private void BackTracking(int n, List<string> list, StringBuilder word)
        {
            if (word.Length == n)
            {
                list.Add(word.ToString());
                return;
            }
            for (int i = 0; i < letters.Length; i++)
            {
                if (word.Length != 0 && word[word.Length - 1] == letters[i])
                    continue;

                word.Append(letters[i]);
                BackTracking(n, list, word);
                word.Remove(word.Length - 1, 1);

            }
        }
    }
}