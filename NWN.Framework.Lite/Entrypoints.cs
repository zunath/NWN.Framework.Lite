using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NWN.Framework.Lite
{
    public class Entrypoints
    {
        private class ActionScript
        {
            public Action Action { get; set; }
            public string Name { get; set; }
        }

        private class ConditionalScript
        {
            public ConditionalScriptDelegate Action { get; set; }
            public string Name { get; set; }
        }

        private const int MaxCharsInScriptName = 16;
        private const int ScriptHandled = 0;
        private const int ScriptNotHandled = -1;

        private delegate bool ConditionalScriptDelegate();

        private static Dictionary<string, List<ActionScript>> _scripts;
        private static Dictionary<string, List<ConditionalScript>> _conditionalScripts;

        /// <summary>
        /// This event runs once every main loop frame, outside of the NWN context.
        /// Ensure this code is performant.
        /// </summary>
        public static event EventHandler MainLoopEvent;

        //
        // This is called once every main loop frame, outside of object context
        //
        internal static void OnMainLoop(ulong frame)
        {
            MainLoopEvent?.Invoke(null, new EventArgs());
        }

        //
        // This is called every time a named script is scheduled to run.
        // oidSelf is the object running the script (OBJECT_SELF), and script
        // is the name given to the event handler (e.g. via SetEventScript).
        // If the script is not handled in the managed code, and needs to be
        // forwarded to the original NWScript VM, return SCRIPT_NOT_HANDLED.
        // Otherwise, return either 0/SCRIPT_HANDLED for void main() scripts,
        // or an int (0 or 1) for StartingConditionals
        //
        internal static int OnRunScript(string script, uint oidSelf)
        {
            var retVal = RunScripts(script);

            if (retVal == -1) return ScriptNotHandled;
            else return retVal;
        }
        //
        // This is called once when the internal structures have been initialized
        // The module is not yet loaded, so most NWScript functions will fail if
        // called here.
        //
        internal static void OnStart()
        {
            Console.WriteLine("Registering scripts...");
            LoadHandlersFromAssembly();

            var count = _conditionalScripts.Count + _scripts.Count;
            Console.WriteLine($"{count} Scripts registered successfully.");
        }

        //
        // This is called once, just before the module load script is called.
        // Unlike OnStart, NWScript functions are available to use here.
        //
        internal static void OnModuleLoad()
        {
            Console.WriteLine("OnModuleLoad() called");
        }

        //
        // This is called once, just before the server will shutdown. In here, you should
        // save anything that might not be flushed to disk, and perform any last cleanup.
        // NWScript functions are available to use.
        //
        internal static void OnShutdown()
        {
            Console.WriteLine("OnShutdown() called");
        }


        private static int RunScripts(string script)
        {
            script = script.ToLower();

            if (_conditionalScripts.ContainsKey(script) )
            {
                // Always default conditional scripts to true. If one or more of the actions return a false,
                // we will return a false (even if others are true).
                // This ensures all actions get fired when the script is called.
                var result = true;

                if (_conditionalScripts.ContainsKey(script))
                {
                    foreach (var action in _conditionalScripts[script])
                    {
                        var actionResult = action.Action.Invoke();
                        if (result) result = actionResult;
                    }
                }

                return result ? 1 : 0;
            }
            else if (_scripts.ContainsKey(script) )
            {
                if (_scripts.ContainsKey(script))
                {
                    foreach (var action in _scripts[script])
                    {
                        try
                        {
                            action.Action();
                        }
                        catch (Exception ex)
                        {
                            var details = ToMessageAndCompleteStacktrace(ex);
                            Console.WriteLine($"C# Script '{script}' threw an exception. Details: {Environment.NewLine}{Environment.NewLine}{details}");
                        }
                    }
                }

                return ScriptHandled;
            }

            return ScriptNotHandled;
        }

        private static void LoadHandlersFromAssembly()
        {
            _scripts = new Dictionary<string, List<ActionScript>>();
            _conditionalScripts = new Dictionary<string, List<ConditionalScript>>();

            var directory = Path.GetDirectoryName(Environment.GetEnvironmentVariable("NWNX_DOTNET_ASSEMBLY"));

            if (string.IsNullOrWhiteSpace(directory))
            {
                Console.WriteLine("Failed to locate directory containing DLLs. Check your NWNX_DOTNET_ASSEMBLY environment variable.");
                return;
            }

            var assemblies = Directory.GetFiles(directory, "*.dll")
                .Select(s => Assembly.Load(AssemblyName.GetAssemblyName(s)));

            var handlers = assemblies
                .SelectMany(s => s.GetTypes())
                .SelectMany(t => t.GetMethods())
                .Where(m => m.GetCustomAttributes(typeof(ScriptHandler), false).Length > 0)
                .ToArray();

            foreach (var mi in handlers)
            {
                foreach (var attr in mi.GetCustomAttributes(typeof(ScriptHandler), false))
                {
                    var script = ((ScriptHandler)attr).Script.ToLower();
                    if (script.Length > MaxCharsInScriptName || script.Length == 0)
                    {
                        Console.WriteLine($"Script name '{script}' is invalid on method {mi.Name}.");
                        throw new ApplicationException();
                    }

                    // If the return type is a bool, it is assumed to be a conditional script.
                    if (mi.ReturnType == typeof(bool))
                    {
                        var del = (ConditionalScriptDelegate)mi.CreateDelegate(typeof(ConditionalScriptDelegate));

                        if (!_conditionalScripts.ContainsKey(script))
                            _conditionalScripts[script] = new List<ConditionalScript>();

                        _conditionalScripts[script].Add(new ConditionalScript
                        {
                            Action = del,
                            Name = del.Method.DeclaringType?.Name + "." + del.Method.Name
                        });
                    }
                    // Otherwise it's a normal script.
                    else if(mi.ReturnType == typeof(void))
                    {
                        var del = (Action)mi.CreateDelegate(typeof(Action));

                        if (!_scripts.ContainsKey(script))
                            _scripts[script] = new List<ActionScript>();

                        _scripts[script].Add(new ActionScript
                        {
                            Action = del,
                            Name = del.Method.DeclaringType?.Name + "." + del.Method.Name
                        });
                    }
                    else
                    {
                        Console.WriteLine($"Method '{mi.Name}' tied to script '{script}' has an invalid return type. This script was NOT loaded.");
                    }

                }
            }
        }

        private static string ToMessageAndCompleteStacktrace(Exception exception)
        {
            var e = exception;
            var s = new StringBuilder();
            while (e != null)
            {
                s.AppendLine("Exception type: " + e.GetType().FullName);
                s.AppendLine("Message       : " + e.Message);
                s.AppendLine("Stacktrace:");
                s.AppendLine(e.StackTrace);

                s.AppendLine();
                e = e.InnerException;
            }

            return s.ToString();
        }
    }
}