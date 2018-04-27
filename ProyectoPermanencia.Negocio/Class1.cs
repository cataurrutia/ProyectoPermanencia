using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPermanencia.AccesoDatos;
using ProyectoPermanencia.Datos;

namespace ProyectoPermanencia.Negocio
{
    public class Class1
    {
        static AccesoFichaGlobal acceso = new AccesoFichaGlobal();

        #region listar todo
        public static List<LK_Alumno> listarAlumnos()
        {
            return acceso.TablaGlobalTotal();
        }
        #endregion
    }
}
