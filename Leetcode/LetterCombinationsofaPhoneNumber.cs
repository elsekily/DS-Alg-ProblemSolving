using System.Text;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class LetterCombinationsofaPhoneNumber
    {
        private Dictionary<char, string> numberToLetters = new Dictionary<char, string>()
        {
            {'2',"abc"},
            {'3',"def"},
            {'4',"ghi"},
            {'5',"jkl"},
            {'6',"mno"},
            {'7',"pqrs"},
            {'8',"tuv"},
            {'9',"wxyz"}
        };
        private List<string> list = new List<string>();
        public IList<string> LetterCombinations(string digits)
        {

            if (digits.Length == 0)
                return list;

            Adder(digits, new StringBuilder());
            return list;
        }
        private void Adder(string digits, StringBuilder current)
        {
            if (digits.Length == 0)
                list.Add(current.ToString());

            else
            {
                foreach (var letter in numberToLetters[digits[0]])
                {
                    current.Append(letter);
                    Adder(digits.Substring(1), current);
                    current.Remove(current.Length - 1, 1);
                }
            }
        }

    }
}