using System.Collections;

namespace homework_prac2
{
    public class Team : ICollection<Unit>
    {
        //ICollection implementation
        private IList<Unit> _list { get; }
        public Team()
        {
            _list = new List<Unit>();
        }
        public Unit this[int index] => (Unit)_list[index];
        public int Count => this._list.Count;
        public bool IsReadOnly => false;
        public void Add(Unit u)
        {
            this._list.Add(u);
        }
        public void Clear()
        {
            this._list.Clear();
        }
        public bool Contains(Unit u)
        {
            return this._list.Contains(u);
        }
        public IEnumerator<Unit> GetEnumerator()
        {
            return new TeamEnumerator(this);
        }
        public bool Remove(Unit u)
        {
            if(u != null && this._list.Contains(u))
            {
                this._list.Remove(u);
                return true;
            }

            return false;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TeamEnumerator(this);
        }
        public void CopyTo(Unit[] array, int index)
        {
            this._list.CopyTo(array, index);
        }
        //End of implementation

        public static Team GenerateRandom(int count)
        {
            Team team = new Team();
            Random rnd = new Random();

            var selection = new List<Unit>()
            {
                new Footman(),
                new Archer(),
                new Wizard()
            };

            for (int i = 0; i < count; i++)
            {
                var index = rnd.Next(0, selection.Count);
                var randomUnit = selection[index];
                team.Add(randomUnit);
            }

            return team;
        }

        public Unit GetRandomAliveUnit()
        {
            Random rnd = new Random();
            int index;

            do
            {
                index = rnd.Next(0, _list.Count);
            }
            while (!_list[index].IsAlive());

            return _list[index];
        }

        public bool IsBroken()
        {
            foreach (var unit in _list)
            {
                if (unit.IsAlive())
                {
                    return false;
                }
            }

            return true;
        }      
    }
}
