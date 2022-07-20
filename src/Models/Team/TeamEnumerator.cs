namespace homework_prac2
{
    public class TeamEnumerator : IEnumerator<Unit>
    {
        private readonly Team _team;
        public int counter = -1;
        public TeamEnumerator(Team team)
        {
            this._team = team;
        }
        public object Current => _team[counter];
        Unit IEnumerator<Unit>.Current => _team[counter];
        public void Dispose()
        {
            counter = -1;
        }
        public bool MoveNext()
        {
            ++counter;
            if(_team.Count > counter)
            {
                return true;
            }

            return false;
        }
        public void Reset()
        {
            counter = -1;
        }
    }
}
