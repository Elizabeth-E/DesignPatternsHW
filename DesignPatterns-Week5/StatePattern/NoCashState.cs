using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternAssignment
{
    class NoCashState : IATMState
    {
        ATMMachine machine = null;

        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode()
        {
            Console.WriteLine("You have entered the correct pin.");
            machine.SetMachineState(machine.GetCardCorrectPinState());
        }

        public void InsertCard()
        {
            Console.WriteLine("A card has already been inserted.");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected.");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("Not enough cash available in the machine.");

            RejectCard();
        }
    }
}
