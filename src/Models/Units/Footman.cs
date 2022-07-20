namespace homework_prac2
{
    internal class Footman : Unit
    {
        private const float _maxHealth = 200f;
        private const float _physResist = 40f;
        private const float _magicResist = 5f;
        private const float _damage = 50f;

        public Footman()
        {
            MaxHealth = _maxHealth;
            CurHealth = _maxHealth;
            PhysResist = _physResist;
            MagicResist = _magicResist;
            Damage = _damage;
        }

        internal override string Name { get; } = "Footman";
    }
}
