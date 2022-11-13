namespace DS_Alg_ProblemSolving.HackerRank
{
    class ThePowerSum
    {
        public int powerSum(int X, int N, int num)
        {
            if (Math.Pow(num, N) < X)
                return powerSum(X, N, num + 1) + powerSum(X - (int)Math.Pow(num, N), N, num + 1);

            else if (Math.Pow(num, N) == X)
                return 1;
            else
                return 0;
        }

        //BackTracking Solution
        private LinkedList<int> list = new LinkedList<int>();
        public int PowerSum(int X, int N)
        {
            BackTracking(X, N, 1, X);
            return count;
        }

        private int count = 0;

        private void BackTracking(int result, int pow, int i, int X)
        {
            if (result == 0)
                count++;

            if (result < 0)
                return;

            while (i < NthRoot(X, pow) + 1)
            {
                list.AddLast(i);
                BackTracking((int)(result - Math.Pow(i, pow)), pow, i + 1, X);
                i++;
                list.RemoveLast();
            }
        }
        private double NthRoot(double number, int root)
        {
            return (int)Math.Pow(number, 1.0 / root);
        }
    }
}