namespace homework_prac2
{
    internal class Wizard : ManaTypeUnit
    {
        private const float _maxHealth = 100f;
        private const float _physResist = 7f;
        private const float _magicResist = 55f;
        private const float _damage = 60f;
        private const float _maxMana = 200f;
        private const float _spellCost = 35f;

        public Wizard()
        {
            MaxHealth = _maxHealth;
            CurHealth = _maxHealth;
            PhysResist = _physResist;
            MagicResist = _magicResist;
            Damage = _damage;
            MaxMana = _maxMana;
            CurMana = _maxMana;
            SpellCost = _spellCost;
        }
    }
}
