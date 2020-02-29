using System;
using System.Runtime.Remoting.Contexts;
using static System.Console;
using static System.Threading.Thread;

namespace ObjectContextApp
{
    // SportsCarTS demands to be loaded in
    // a synchronization context.
    [Synchronization]
    class SportsCarThreadSafe : ContextBoundObject
    {
        public SportsCarThreadSafe()
        {
            // Get context information and print out context ID.
            Context context = CurrentContext;
            WriteLine($"{ToString()} object in context {context.ContextID}.");
            foreach (IContextProperty iContextProperty in context.ContextProperties)
                WriteLine($"-> Context Property: {iContextProperty.Name}.");
        }
    }
}
