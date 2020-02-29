using System.Runtime.Remoting.Contexts;
using static System.Console;
using static System.Threading.Thread;

namespace ObjectContextApp
{
    // SportsCar has no special contextual
    // needs and will be loaded into the
    // default context of the app domain.
    class SportsCar
    {
        public SportsCar()
        {
            // Get context information and print out context ID.
            Context context = CurrentContext;
            WriteLine($"{ToString()} object in context {context.ContextID}.");
            foreach (IContextProperty iContextProperty in context.ContextProperties)
                WriteLine($"-> Ctx Prop: {iContextProperty.Name}.");
        }
    }
}
