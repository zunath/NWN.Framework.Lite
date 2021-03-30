using System;

namespace NWN.Framework.Lite
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ScriptHandler : Attribute
    {
        public string Script { get; }

        public ScriptHandler(string script)
        {
            Script = script;
        }

    }
}