using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPermanencia.AccesoDatos;
using ProyectoPermanencia.Datos;

namespace ProyectoPermanencia.Negocio
{
    class NegocioGlobal
    {
        static AccesoAlumno acceso = new AccesoAlumno(); 

        public static LK_Alumno Alumno(String alumno, String carrera, String jornada, String sede)
        {
            AccesoAlumno acAlum;
            if (!RecuperarAlumno(alumno, carrera, jornada, sede out acAlum))
                throw new Exception("Alumno no existe");
            else
                return acAlum;
        }

        private static Boolean RecuperarAlumno(String usuario, String password, out LK_Alumno usrLogin)
        {
            bool validacion;
            usrLogin = acceso.obtenerEstado(usuario, password);
            if (usrLogin != null)
            {
                validacion = usrLogin.pass_administrador.Equals(password);
            }
            else
            {
                validacion = false;
            }
            return validacion;
        }


    }
}
}
