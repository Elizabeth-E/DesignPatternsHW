using assignment1;

internal class Program
{
    private static void Main(string[] args)
    {
        new Program().Start();
    }
    void Start()
    {
        IStack myStack = new ArrayStack(50);
        AddValues(myStack);
        Console.WriteLine();
        CheckValues(myStack);
        Console.WriteLine();
        ProcessValues(myStack);
        Console.ReadKey();
    }
    void AddValues(IStack stack)
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int value = random.Next(0, 100);
            stack.Push(value);
            Console.WriteLine($"pushed {value,2}, new count: {stack.Count}");
        }

    }
    void CheckValues(IStack stack)
    {
        for (int i = 0; i < 3; i++)
        {
            try
            {
                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (!stack.Contains(input))
                {
                    Console.WriteLine("stack does not contain value {0}", input);
                }
                else
                {
                    Console.WriteLine("stack contains value {0}", input);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("please enter valid input!");
            }
        }
    }
    void ProcessValues(IStack stack)
    {
        while (!stack.IsEmpty)
        {
            int value = stack.Pop();
            Console.WriteLine($"popped {value}, new count: {stack.Count}");
        }
    }
}