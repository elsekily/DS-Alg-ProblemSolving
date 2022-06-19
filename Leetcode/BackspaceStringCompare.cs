using System.Text;
namespace DS_Alg_ProblemSolving.Leetcode
{
    public class BackspaceStringCompare
    {
        public bool BackspaceCompare(string s, string t)
        {
            var sString = BuildString(s);
            var tString = BuildString(t);

            if (sString.Length != tString.Length)
                return false;

            for (int i = 0; i < sString.Length; i++)
            {
                if (sString[i] != tString[i])
                    return false;
            }
            return true;
        }
        private string BuildString(string word)
        {
            var output = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '#' && output.Length == 0)
                    continue;
                if (word[i] == '#')
                    output.Remove(output.Length - 1, 1);
                else
                    output.Append(word[i]);
            }
            return output.ToString();
        }
    }
}