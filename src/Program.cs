namespace homework_prac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = Team.GenerateRandom(5);

            for (int i = 0; i < team.Count; i++)
            {
                Console.WriteLine(team[i].Name);
            }
        }
    }
}