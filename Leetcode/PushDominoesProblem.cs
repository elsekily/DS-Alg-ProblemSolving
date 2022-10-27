using System.Text;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class PushDominoesProblem
    {
        public string PushDominoes(string dominoes)
        {
            var result = new StringBuilder(dominoes);
            var arr = new int[dominoes.Length];

            var lastR = dominoes.Length;
            var lastL = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (dominoes[i] == 'R')
                {
                    lastR = i;
                    continue;
                }
                else if (dominoes[i] == 'L')
                {
                    lastR = dominoes.Length;
                    continue;
                }
                arr[i] = lastR > i ? 0 : i - lastR;
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (dominoes[i] == 'L')
                {
                    lastL = i;
                    continue;
                }
                else if (dominoes[i] == 'R')
                {
                    lastL = 0;
                    continue;
                }

                var temp = lastL < i ? 0 : i - lastL;

                if (temp + arr[i] == 0)
                    continue;
                else if (temp == 0 && arr[i] > 0)
                    result[i] = 'R';
                else if (temp + arr[i] < 0 && arr[i] != 0)
                    result[i] = 'R';
                else
                    result[i] = 'L';

            }
            return result.ToString();
        }
    }
}