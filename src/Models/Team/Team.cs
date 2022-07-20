using System.Collections;

namespace homework_prac2
{
    public class Team : ICollection<Unit>
    {
        //ICollection implementation
        private IList<Unit> List { get; }
        public Team()
        {
            List = new List<Unit>();
        }
        public Unit this[int index] => (Unit)List[index];
        public int Count => this.List.Count;
        public bool IsReadOnly => false;
        public void Add(Unit u)
        {
            this.List.Add(u);
        }
        public void Clear()
        {
            this.List.Clear();
        }
        public bool Contains(Unit u)
        {
            return this.List.Contains(u);
        }
        public IEnumerator<Unit> GetEnumerator()
        {
            return new TeamEnumerator(this);
        }
        public bool Remove(Unit u)
        {
            if(u != null && this.List.Contains(u))
            {
                this.List.Remove(u);
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
            this.List.CopyTo(array, index);
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
                var selectionRange = rnd.Next(0, selection.Count);
                var randomUnit = selection[selectionRange];
                team.Add(randomUnit);
            }

            return team;
        }
    }
}
