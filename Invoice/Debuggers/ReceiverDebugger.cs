using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Invoice
{
    public class ReceiverDebugger : InvoiceDebugger
    {
        public ReceiverDebugger(string receiver, int price, DateTime date) : base(receiver, price, date) { }

        public override void DebugValue()
        {
            Debug.WriteLine(_receiver);
        }
    }
}
