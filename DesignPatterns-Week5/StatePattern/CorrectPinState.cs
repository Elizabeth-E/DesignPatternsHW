using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternAssignment
{
    class CorrectPinState : IATMState
    {
        ATMMachine machine = null;

        public CorrectPinState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode()
        {
            Console.WriteLine("You have entered the correct pincode.");
        }

        public void InsertCard()
        {
            Console.WriteLine("A card has been inserted already.");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected.");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void WithdrawCash(int amount)
        {
            if (amount <= machine.AmountInMachine)
            {
                machine.SetAmountInMachine(amount);
                Console.WriteLine("{0} withdrawn from the machine.", amount);
            }
            else
            {
                Console.WriteLine("Not enough cash available in the machine.");
                machine.SetMachineState(machine.GetNoCashState());
            }

            RejectCard();
        }
    }
}
