using System;

namespace StatePatternAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            ATMMachine machine = new ATMMachine(2000);


            while (true)
            {
                Console.Write("Please enter your command: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string insertedCommand = Console.ReadLine();
                Console.ResetColor();

                switch (insertedCommand.ToLower())
                {
                    case "stop":
                        return;
                    case "insert card":
                        machine.InsertCard();
                        break;
                    case "reject card":
                        machine.RejectCard();
                        break;
                    case "enter pincode":
                        machine.EnterPincode();
                        break;
                    case "withdraw cash":
                        machine.WithdrawCash();
                        break;
                    case "check amount":
                        machine.CheckAmount();
                        break;
                    default:
                        Console.WriteLine("entered unknown command");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
