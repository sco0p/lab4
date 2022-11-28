using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Invoice
{
    public class PriceDebugger : InvoiceDebugger
    {
        public PriceDebugger(string receiver, int price, DateTime date) : base(receiver, price, date) { }

        public override void DebugValue()
        {
            Debug.WriteLine(_price.ToString());
        }
    }
}
