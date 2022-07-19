namespace homework_prac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Archer archer = new Archer();
            //Footman footman = new Footman();
            //Wizard wizard = new Wizard();
            //Console.WriteLine($"MaxHealth: {archer.MaxHealth}, CurHealth: {archer.CurHealth}, " +
            //    $"PRes: {archer.PhysResist}, MRes: {archer.MagicResist}, Damage: {archer.Damage}, Ammo: {archer.CurAmmo}");
            //Console.WriteLine($"MaxHealth: {footman.MaxHealth}, CurHealth: {footman.CurHealth}, " +
            //    $"PRes: {footman.PhysResist}, MRes: {footman.MagicResist}, Damage: {footman.Damage}");
            //Console.WriteLine($"MaxHealth: {wizard.MaxHealth}, CurHealth: {wizard.CurHealth}, " +
            //    $"PRes: {wizard.PhysResist}, MRes: {wizard.MagicResist}, Damage: {wizard.Damage}, CurMana: {wizard.CurMana}");

            //wizard.Attack(footman);

            //Console.WriteLine("\nAttacked\n");

            //Console.WriteLine($"MaxHealth: {footman.MaxHealth}, CurHealth: {footman.CurHealth}, " +
            //    $"PRes: {footman.PhysResist}, MRes: {footman.MagicResist}, Damage: {footman.Damage}");
            //Console.WriteLine($"MaxHealth: {wizard.MaxHealth}, CurHealth: {wizard.CurHealth}, " +
            //    $"PRes: {wizard.PhysResist}, MRes: {wizard.MagicResist}, Damage: {wizard.Damage}, CurMana: {wizard.CurMana}");

            //Unit arch = new Archer();
            //Console.Write(arch is Archer);

            //Team team = new Team()
            //{
            //    new Wizard(),
            //    new Footman(),
            //    new Archer()
            //};
            //team.Insert(3, new Wizard());
            //Console.WriteLine(team.Count);
            //Console.WriteLine(team.IndexOf(new Footman()));
            Wizard w1 = new();
            Wizard w2 = new();
            Archer a1 = new();
            Console.WriteLine(w1.Equals(a1));

        }
    }
}