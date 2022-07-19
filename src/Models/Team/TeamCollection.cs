namespace homework_prac2
{
    public class Team : IList<Unit>
    {
        private List<Unit> _units;
        public Team()
        {
            _units = new List<Unit>();
        }

        public Unit this[int index] { get => _units[index]; set => _units[index] = value; }

        public int Count => _units.Count;

        public bool IsReadOnly => false;

        public void Add(Unit item)
        {
            _units.Add(item);
        }
            
        public void Clear()
        {
            _units.Clear();
        }

        public bool Contains(Unit item)
        {
            bool found = false;

            foreach(Unit unit in _units)
            {
                if (unit.Equals(item))
                {
                    found = true;
                }
            }

            return found;
         }

        public void CopyTo(Unit[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < _units.Count; i++)
            {
                array[i + arrayIndex] = _units[i];
            }
        }

        public IEnumerator<Unit> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Unit item)
        {
            return _units.IndexOf(item);
        }

        public void Insert(int index, Unit item)
        {
            _units.Insert(index, item);
        }

        public bool Remove(Unit item)
        {
            bool result = false;

            for (int i = 0; i < _units.Count; i++)
            {

                Unit curUnit = _units[i];

                if (new UnitComparer().Equals(curUnit, item))
                {
                    _units.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void RemoveAt(int index)
        {
            _units.RemoveAt(index);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new UnitEnumerator(this);
        }
    }

    public class UnitComparer : EqualityComparer<Unit>
    {

        public override bool Equals(Unit? u1, Unit? u2)
        {
            if (u1?.MaxHealth == u2?.MaxHealth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Unit u)
        {
            float res = u.MaxHealth * u.MagicResist * u.PhysResist;
            return res.GetHashCode();
        }
    }

    public class UnitEnumerator : IEnumerator<Unit>
    {
        private Team? _teamCol;
        private int curIndex;
        private Unit? curUnit;

        public UnitEnumerator(Team collection)
        {
            _teamCol = collection;
            curIndex = -1;
            curUnit = default;
        }

        public bool MoveNext()
        {
            if (++curIndex >= _teamCol?.Count)
            {
                return false;
            }
            else
            {
                curUnit = _teamCol?[curIndex];
            }
            return true;
        }

        public void Reset() { curIndex = -1; }

        void IDisposable.Dispose() { }

        public Unit Current
        {
            get { return curUnit; }
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
