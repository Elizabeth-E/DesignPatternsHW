using assignment2;

internal class Program
{
    private static void Main(string[] args)
    {
        new Program().Start();
    }
    private void Start()
    {
        Console.WriteLine("[shop creating expensive computers]");
        HighBudgetFactory highBudgetFactory = new HighBudgetFactory();
        ComputerShop highBudgetShop = new ComputerShop(highBudgetFactory);

        Computer highBudgetComputer = highBudgetShop.AssembleComputer();
        highBudgetComputer.Test();
        Console.WriteLine();


        Console.WriteLine("[shop creating cheap computers]");
        LowBudgetFactory lowBudgetFactory = new LowBudgetFactory();
        ComputerShop lowBudgetShop = new ComputerShop(lowBudgetFactory);

        Computer lowBudgetComputer = lowBudgetShop.AssembleComputer();
        lowBudgetComputer.Test();
    }
}