using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfsdk
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Console.WriteLine(ThisAssembly.AssemblyFileVersion);
        }
    }
}
