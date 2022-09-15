using System.Text;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class RomanNumbers
    {
        private Dictionary<char, int> romanToIntger = new Dictionary<char, int>()
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
        private Dictionary<int, char> intgerToRoman = new Dictionary<int, char>()
        {
            {1,'I'},
            {5,'V'},
            {10,'X'},
            {50,'L'},
            {100,'C'},
            {500,'D'},
            {1000,'M'}
        };
        public string IntToRoman(int num)
        {
            var romanNumber = new StringBuilder();

            for (int i = 1000; i > 0; i /= 10)
            {
                var current = num / i;
                if (current <= 3)
                {
                    for (int j = 0; j < current; j++)
                    {
                        romanNumber.Append(intgerToRoman[i]);
                    }
                }
                else if (current <= 4)
                {
                    romanNumber.Append(intgerToRoman[i]);
                    romanNumber.Append(intgerToRoman[i * 5]);
                }
                else if (current <= 8)
                {
                    romanNumber.Append(intgerToRoman[i * 5]);
                    var j = current - 5;
                    while (j > 0)
                    {
                        romanNumber.Append(intgerToRoman[i]);
                        j--;
                    }
                }
                else
                {
                    romanNumber.Append(intgerToRoman[i]);
                    romanNumber.Append(intgerToRoman[i * 10]);
                }
                num = num % i;
            }


            return romanNumber.ToString();
        }
        public int RomanToInt(string s)
        {
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i != s.Length - 1 && romanToIntger[s[i]] < romanToIntger[s[i + 1]])
                    sum -= romanToIntger[s[i]];

                else
                    sum += romanToIntger[s[i]];

            }
            return sum;
        }
    }
}