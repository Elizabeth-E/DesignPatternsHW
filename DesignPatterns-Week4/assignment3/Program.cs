using assignment3;

internal class Program
{
    private static void Main(string[] args)
    {
        new Program().Start();
    }
    void Start()
    {
        List<IAttacker> attackers = new List<IAttacker>();

        Tank tank = new Tank("Frank");
        RobotAdapter robot = new RobotAdapter("Mark");

        attackers.Add(tank);
        attackers.Add(robot);
        Console.WriteLine();

        // process all attackers
        foreach (IAttacker attacker in attackers)
        {
            Console.WriteLine($"Driver of attacker: {attacker.Driver}");
            attacker.DriveForward();
            attacker.UseWeapon();
            Console.WriteLine();
        }
    }
}