using System;

namespace NWN.Framework.Lite.Core
{
    public class Profiler : IDisposable
    {
        public Profiler(string name)
        {
            //NWNXProfiler.PushPerfScope(name, "RunScript", "Script");
        }

        public void Dispose()
        {
            //NWNXProfiler.PopPerfScope();
        }
    }
}
