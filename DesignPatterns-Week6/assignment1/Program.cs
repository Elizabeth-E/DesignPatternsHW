using assignment1;

internal class Program
{
    private static void Main(string[] args)
    {
        new Program().Start();
    }
    private void Start()
    {
        HighBudgetShop highBudgetShop = new HighBudgetShop();
        Console.WriteLine("[shop creating expensive computers]");
        Computer highBudgetComputer = highBudgetShop.AssembleComputer();
        highBudgetComputer.Test();
        Console.WriteLine();

        LowBudgetShop lowBudgetShop = new LowBudgetShop();
        Console.WriteLine("[shop creating cheap computers]");
        Computer lowBudgetComputer = lowBudgetShop.AssembleComputer();
        lowBudgetComputer.Test();
    }
}