using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPermanencia.Datos
{
     public static class MainC
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments:
            System.Console.WriteLine( new AccesoFichaGlobal().tablaGlobal(new string[] { "187411998", "216548548" }, new string[] { }, new string[] { }, new string[] { }, new string[] { }));
        }
    }
}
