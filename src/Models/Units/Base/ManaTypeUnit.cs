namespace homework_prac2
{
    internal abstract class ManaTypeUnit : Unit
    {
        private readonly float _maxMana;
        private readonly float _spellCost;

        private float _curMana;

        internal override string Name { get; } = "ManaTypeUnit";
        internal float MaxMana { get => _maxMana; init => _maxMana = value; }
        internal float CurMana
        {
            get => _curMana;
            set
            {
                _curMana = value;

                if (_curMana > MaxMana)
                {
                    _curMana = MaxMana;
                }
                else if (_curMana < 0)
                {
                    _curMana = 0;
                }
            }
        }
        internal float SpellCost { get => _spellCost; init => _spellCost = value; }

        internal override float CalcDamage(Unit target)
        {
            float damageAbsorb = Damage * (target.MagicResist / 100f);
            float damageDealt = Damage - damageAbsorb;
            return damageDealt;
        }

        internal override void Attack(Unit target)
        {
            if(CurMana > SpellCost)
            {
                base.Attack(target);
                CurMana -= SpellCost;
            }
        }
    }
}
