using assignment2;
internal class Program
{
    private static void Main(string[] args)
    {        
        new Program().Start();
    }
    void Start() {
        string message;

        IPencil pencil = new Pencil();
        IPencilSharpener pencilSharpener = new PencilSharpener();

        while (true) {
            Console.Write("Enter a message: ");
            message = Console.ReadLine() ?? string.Empty;

            switch (message.ToLower()) {
                case "stop":
                    Console.WriteLine("Pencils down! Program ending.");
                    return;
                case "sharpen":
                    pencilSharpener.Sharpen(pencil);
                    break;
                default:
                    pencil.Write(message);
                    break;
            }
        }
    }
}