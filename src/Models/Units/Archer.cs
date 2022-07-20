namespace homework_prac2
{
    internal class Archer : AmmoTypeUnit
    {
        private const float _maxHealth = 130f;
        private const float _physResist = 25f;
        private const float _magicResist = 15f;
        private const float _damage = 35f;
        private const int _maxAmmo = 10;

        public Archer()
        {
            MaxHealth = _maxHealth;
            CurHealth = _maxHealth;
            PhysResist = _physResist;
            MagicResist = _magicResist;
            Damage = _damage;
            MaxAmmo = _maxAmmo;
            CurAmmo = _maxAmmo;
        }

        internal override string Name { get; } = "Archer";
    }
}
