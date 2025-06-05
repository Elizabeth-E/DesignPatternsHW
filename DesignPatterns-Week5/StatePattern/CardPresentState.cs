using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternAssignment
{
    class CardPresentState : IATMState
    {
        ATMMachine machine = null;

        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode()
        {
            Console.Write("Please enter your pincode:");
            uint pin = uint.Parse(Console.ReadLine());
            if (pin == 1234)
            {
                Console.WriteLine("You have entered the correct pincode");
                machine.SetMachineState(machine.GetCardCorrectPinState());
            }
            else
            {
                Console.WriteLine("Incorrect pincode");
                RejectCard();
            }
        }

        public void InsertCard()
        {
            Console.WriteLine("A card has been inserted already");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected.");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void WithdrawCash(int amount)
        {
            if (amount > machine.AmountInMachine)
            {
                Console.WriteLine("Not enough cash available in the machine.");
                machine.SetMachineState(machine.GetNoCashState());
            }
            else
            {
                machine.SetAmountInMachine(amount);
                Console.WriteLine("{0} withdrawn from the machine.", amount);
            }

            RejectCard();

        }
    }
}
