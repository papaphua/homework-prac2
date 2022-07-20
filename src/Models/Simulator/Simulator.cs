namespace homework_prac2
{
    internal class Simulator
    {
        internal Simulator(Team t1, Team t2)
        {
            this.Notify = BattleLogger;
            Notify?.Invoke("Battle started:\n");
            this.StartSimulation(t1, t2);
        }

        private delegate void BattleHandler(string message);
        private event BattleHandler? Notify;

        private void BattleLogger(string message)
        {
            Console.WriteLine(message);
        }

        private void StartSimulation(Team t1, Team t2)
        {
            while (true)
            {
                if (t1.IsBroken())
                {
                    Notify?.Invoke($"TEAM_1 is broken");
                    return;
                }
                if (t2.IsBroken())
                {
                    Notify?.Invoke($"TEAM_2 is broken");
                    return ;
                }

                //t1
                Notify?.Invoke("TEAM_1 starts actions:");
                foreach (var unit in t1)
                {
                    if (unit.IsAlive())
                    {
                        var target = t2.GetRandomAliveUnit();
                        unit.Attack(target);
                        Notify?.Invoke($"{unit.Name}({unit.CurHealth}/{unit.MaxHealth}) attacks {target.Name}({target.CurHealth}/{target.MaxHealth})");
                    }
                }

                Console.WriteLine();

                //t2
                Notify?.Invoke("TEAM_2 starts actions:");
                foreach (var unit in t2)
                {
                    if (unit.IsAlive())
                    {
                        var target = t1.GetRandomAliveUnit();
                        unit.Attack(target);
                        Notify?.Invoke($"{unit.Name}({unit.CurHealth}/{unit.MaxHealth}) attacks {target.Name}({target.CurHealth}/{target.MaxHealth})");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
