using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    public abstract class InvoiceDebugger : Invoice
    {
        public InvoiceDebugger(string receiver, int price, DateTime date) : base(receiver, price, date) { }

        virtual public void DebugValue() { }
    }
}
