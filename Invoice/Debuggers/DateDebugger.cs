using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    public class DateDebugger : InvoiceDebugger
    {
        public DateDebugger(string receiver, int price, DateTime date) : base(receiver, price, date) { }

        public override void DebugValue()
        {
            System.Diagnostics.Debug.WriteLine(_date.ToLongTimeString());
        }
    }
}
