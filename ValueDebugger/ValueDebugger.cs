using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ValueDebugger
{
    public class ValueDebugger
    {
        virtual internal void WriteInDebug(string stringParam, int intParam)
        {
            Debug.WriteLine("String Parameter: " + stringParam);
            Debug.Write("Integer Parameter: " + intParam);
        }
    }
}
