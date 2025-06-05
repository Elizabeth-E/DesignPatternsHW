using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternAssignment
{
    class ATMMachine
    {
        private IATMState currentState = null;
        private IATMState correctPinCode = null;
        private IATMState cardPresent = null;
        private IATMState noCard = null;
        private IATMState noCash = null;

        public int AmountInMachine = 0;

        public ATMMachine(int amountInMachine)
        {
            noCard = new NoCardState(this);
            cardPresent = new CardPresentState(this);
            noCash = new NoCashState(this);
            correctPinCode = new CorrectPinState(this);

            AmountInMachine = amountInMachine;

            if (amountInMachine > 0)
                currentState = noCard;
            else
                currentState = noCash;
        }

        public void EnterPincode()
        {
            currentState.EnterPincode();
        }
        public void InsertCard()
        {
            currentState.InsertCard();
        }

        public void RejectCard()
        {
            currentState.RejectCard();
        }

        public void WithdrawCash()
        {
            Console.Write("Please enter amount of cash:");
            int amount = int.Parse(Console.ReadLine());
            currentState.WithdrawCash(amount);
        }
        public void CheckAmount()
        {
            Console.WriteLine(AmountInMachine);
        }

        public void SetAmountInMachine(int amount)
        {
            this.AmountInMachine = AmountInMachine - amount;
        }

        public void SetMachineState(IATMState state)
        {
            currentState = state;
        }
        public IATMState GetCardPresentState()
        {
            return cardPresent;
        }

        public IATMState GetCardCorrectPinState()
        {
            return correctPinCode;
        }

        public IATMState GetNoCardState()
        {
            return noCard;
        }

        public IATMState GetNoCashState()
        {
            return noCash;
        }
    }
}
