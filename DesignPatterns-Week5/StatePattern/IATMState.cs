using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternAssignment
{
    interface IATMState
    {
        public void EnterPincode();
        public void InsertCard();
        public void RejectCard();
        public void WithdrawCash(int amount);
    }
}
