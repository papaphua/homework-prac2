namespace homework_prac2
{
    public abstract class Unit
    {
        private readonly float _maxHealth;
        private readonly float _physResist;
        private readonly float _magicResist;
        private readonly float _damage;

        private float _curHealth;

        internal virtual string Name { get; } = "Unit";
        internal float MagicResist { get => _magicResist; init => _magicResist = value; }
        internal float MaxHealth { get => _maxHealth; init => _maxHealth = value; }
        internal float PhysResist { get => _physResist; init => _physResist = value; }
        internal float Damage { get => _damage; init => _damage = value; }
        internal float CurHealth
        {
            get => _curHealth;
            set
            {
                _curHealth = value;

                if (_curHealth > MaxHealth)
                {
                    _curHealth = MaxHealth;
                }
                else if (_curHealth < 0)
                {
                    _curHealth = 0;
                }
            }
        }

        internal virtual float CalcDamage(Unit target)
        {
            float damageAbsorb = Damage * (target.PhysResist / 100f);
            Console.WriteLine($"absorvPerc = {damageAbsorb}");
            float damageDealt = Damage - damageAbsorb;
            Console.WriteLine($"damDealt = {damageDealt}");
            return damageDealt;
        }

        internal virtual void Attack(Unit target)
        {
            float damageDealt = CalcDamage(target);
            target.CurHealth -= damageDealt;
        }
    }
}
