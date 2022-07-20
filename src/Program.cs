namespace homework_prac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team t1 = Team.GenerateRandom(2);
            Team t2 = Team.GenerateRandom(2);

            Simulator simulator = new Simulator(t1, t2);
        }
    }
}
