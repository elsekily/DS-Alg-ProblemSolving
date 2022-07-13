namespace DS_Alg_ProblemSolving.Leetcode
{
    public class KeysandRooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var visited = new HashSet<int>();

            var stack = new Stack<int>();
            stack.Push(0);
            while (stack.Count != 0)
            {
                var index = stack.Pop();
                visited.Add(index);
                for (int i = 0; i < rooms[index].Count; i++)
                {
                    if (!visited.Contains(rooms[index][i]))
                        stack.Push(rooms[index][i]);
                }
            }

            if (rooms.Count == visited.Count)
                return true;
            return false;
        }
        public bool CanVisitAllRoomsREC(IList<IList<int>> rooms)
        {
            var visited = new HashSet<int>();
            Wander(rooms, visited, 0);
            if (rooms.Count == visited.Count)
                return true;

            return false;
        }
        private void Wander(IList<IList<int>> rooms, HashSet<int> visited, int index)
        {
            if (visited.Contains(index))
                return;

            visited.Add(index);
            for (int i = 0; i < rooms[index].Count; i++)
                Wander(rooms, visited, rooms[index][i]);
        }
    }
}