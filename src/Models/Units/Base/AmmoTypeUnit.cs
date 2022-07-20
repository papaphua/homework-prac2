namespace homework_prac2
{
    internal abstract class AmmoTypeUnit : Unit
    {
        private readonly int _maxAmmo;

        private int _curAmmo;

        internal override string Name { get; } = "AmmoTypeUnit";
        internal int MaxAmmo { get => _maxAmmo; init => _maxAmmo = value; }
        internal int CurAmmo
        {
            get => _curAmmo;
            set
            {
                _curAmmo = value;

                if (_maxAmmo > MaxAmmo)
                {
                    _curAmmo = MaxAmmo;
                }
                else if (_maxAmmo < 0)
                {
                    _curAmmo = 0;
                }
            }
        }

        internal override void Attack(Unit target)
        {
            if(CurAmmo > 0)
            {
                base.Attack(target);
                CurAmmo -= 1;
            }
        }
    }
}
