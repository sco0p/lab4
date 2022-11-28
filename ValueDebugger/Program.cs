using System;

namespace ValueDebugger
{
    class Program
    {
        static void Main()
        {
            var typeDebugger = new TypeDebugger();

            typeDebugger.WriteInDebug("sad", 123);
        }
    }
}
