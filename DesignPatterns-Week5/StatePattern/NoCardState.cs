using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternAssignment
{
    class NoCardState : IATMState
    {
        ATMMachine machine = null;

        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode()
        {
            Console.WriteLine("You cannot enter a pincode without a card.");
        }

        public void InsertCard()
        {
            Console.WriteLine("Card has been inserted");
            machine.SetMachineState(machine.GetCardPresentState());
        }

        public void RejectCard()
        {
            Console.WriteLine("You cannot eject when no card is present.");
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("Cannot withdraw cash without card.");
        }
    }
}
