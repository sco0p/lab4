using System;

namespace Invoice
{
    class Program
    {
        static void Main()
        {
            var receiver = "Andrii";
            var price = 25;
            var date = DateTime.Now;

            InvoiceDebugger[] debuggers = { new DateDebugger(receiver, price, date), new PriceDebugger(receiver, price, date), new ReceiverDebugger(receiver, price, date) };

            foreach (var debugger in debuggers)
            {
                debugger.DebugValue();
            }

            Console.WriteLine("Done!");
        }
    }
}
