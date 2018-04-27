using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPermanencia.Datos
{
    public class AccesoFichaGlobal
    {
        /**
         * Objetos de prueba para usar en Servicio, estos seran eliminados luego de que defina 
         * y crea la capa de Entidades. */
        public String Rut { get; set; }
        public String Nombre { get; set; }
        public String Jornada { get; set; }
        public String Escuela { get; set; }
        public String Carrera { get; set; }
        /// <summary>
        /// Accede a la tabla global de todos los alumnos
        /// </summary>
        /// <param name="rut"></param>
        /// <param name="nombre"></param>
        /// <param name="jornada"></param>
        /// <param name="escuela"></param>
        /// <param name="carrera"></param>
        /// <returns></returns>
        public List<AccesoFichaGlobal> TablaGlobalTotal(string[] rut, string[] nombre, string[] jornada, string[] escuela, string[] carrera)
        {
            //Inicia instancia para el acceso de la base de datos, y luego de terminar el proceso, esta es borrada.
            using (PermanenciaDBContext accesoBdPermanecia = new PermanenciaDBContext())
            {
                /**
                * Linq de consulta, une las tablas de LK_Alumno, LK_Jornada, 
                * LK_Sede, LK_Carrera, y busca a travez de los parametros de entrada
                * del metodo.
                * */
                try
                {
                    var queryBuscarInfoAlumnos = (from a in accesoBdPermanecia.LK_Alumno
                                                  join j in accesoBdPermanecia.LK_Jornada on a.Id_Jornada equals j.Id_Jornada
                                                  join s in accesoBdPermanecia.LK_Sede on a.Id_Sede equals s.Id_Sede
                                                  join c in accesoBdPermanecia.LK_Carrera on a.Id_Carrera equals c.Id_Carrera
                                                  where rut.Contains(a.Desc_Rut_Alumno) || nombre.Contains(a.Desc_Alumno) && jornada.Contains(j.Desc_Jornada)
                                                  && escuela.Contains(s.Desc_Sede) && carrera.Contains(c.Desc_Carrera)
                                                  select new AccesoFichaGlobal
                                                  {
                                                      Nombre = a.Desc_Alumno,
                                                      Rut = a.Desc_Rut_Alumno,
                                                      Carrera = c.Desc_Carrera,
                                                      Escuela = s.Desc_Sede,
                                                      Jornada = j.Desc_Jornada 
                                                  }).ToList();

                 return queryBuscarInfoAlumnos; //Retorna una lista de informacion de cada alummno referente a la Tabla Global.

                }
                catch (NullReferenceException ex)
                {

                    throw;
                }
            }
        }

        public List<AccesoFichaGlobal> TablaGlobalSoloTipoJornada(string[] rut, string[] nombre, string[] jornada, string[] escuela, string[] carrera)
        {
            //Inicia instancia para el acceso de la base de datos, y luego de terminar el proceso, esta es borrada.
            using (PermanenciaDBContext accesoBdPermanecia = new PermanenciaDBContext())
            {
                /**
                * Linq de consulta, une las tablas de LK_Alumno, LK_Jornada, 
                * LK_Sede, LK_Carrera, y busca a travez de los parametros de entrada
                * del metodo.
                * */
                try
                {
                    var queryBuscarInfoAlumnos = (from a in accesoBdPermanecia.LK_Alumno
                                                  join j in accesoBdPermanecia.LK_Jornada on a.Id_Jornada equals j.Id_Jornada
                                                  join s in accesoBdPermanecia.LK_Sede on a.Id_Sede equals s.Id_Sede
                                                  join c in accesoBdPermanecia.LK_Carrera on a.Id_Carrera equals c.Id_Carrera
                                                  where rut.Contains(a.Desc_Rut_Alumno) || nombre.Contains(a.Desc_Alumno) && jornada.Contains(j.Desc_Jornada)
                                                  select new AccesoFichaGlobal
                                                  {
                                                      Nombre = a.Desc_Alumno,
                                                      Rut = a.Desc_Rut_Alumno,
                                                      Carrera = c.Desc_Carrera,
                                                      Escuela = s.Desc_Sede,
                                                      Jornada = j.Desc_Jornada
                                                  }).ToList();

                 return queryBuscarInfoAlumnos; //Retorna una lista de informacion de cada alummno referente a la Tabla Global.

                }
                catch (NullReferenceException ex)
                {

                    throw;
                }
            }
        }

        public List<AccesoFichaGlobal> TablaGlobalSoloTipoEscuela(string[] rut, string[] nombre, string[] jornada, string[] escuela, string[] carrera)
        {
            //Inicia instancia para el acceso de la base de datos, y luego de terminar el proceso, esta es borrada.
            using (PermanenciaDBContext accesoBdPermanecia = new PermanenciaDBContext())
            {
                /**
                * Linq de consulta, une las tablas de LK_Alumno, LK_Jornada, 
                * LK_Sede, LK_Carrera, y busca a travez de los parametros de entrada
                * del metodo.
                * */
                try
                {
                    var queryBuscarInfoAlumnos = (from a in accesoBdPermanecia.LK_Alumno
                                                  join j in accesoBdPermanecia.LK_Jornada on a.Id_Jornada equals j.Id_Jornada
                                                  join s in accesoBdPermanecia.LK_Sede on a.Id_Sede equals s.Id_Sede
                                                  join c in accesoBdPermanecia.LK_Carrera on a.Id_Carrera equals c.Id_Carrera
                                                  where rut.Contains(a.Desc_Rut_Alumno) || nombre.Contains(a.Desc_Alumno) && escuela.Contains(s.Desc_Sede)
                                                  select new AccesoFichaGlobal
                                                  {
                                                      Nombre = a.Desc_Alumno,
                                                      Rut = a.Desc_Rut_Alumno,
                                                      Carrera = c.Desc_Carrera,
                                                      Escuela = s.Desc_Sede,
                                                      Jornada = j.Desc_Jornada
                                                  }).ToList();

                    return queryBuscarInfoAlumnos; //Retorna una lista de informacion de cada alummno referente a la Tabla Global.
                }
                catch (NullReferenceException ex)
                {

                    throw;
                }
            }
        }

        public List<AccesoFichaGlobal> TablaGlobalSoloTipoCarrera(string[] rut, string[] nombre, string[] jornada, string[] escuela, string[] carrera)
        {
            //Inicia instancia para el acceso de la base de datos, y luego de terminar el proceso, esta es borrada.
            using (PermanenciaDBContext accesoBdPermanecia = new PermanenciaDBContext())
            {
                /**
                * Linq de consulta, une las tablas de LK_Alumno, LK_Jornada, 
                * LK_Sede, LK_Carrera, y busca a travez de los parametros de entrada
                * del metodo.
                * */
                try
                {
                    var queryBuscarInfoAlumnos = (from a in accesoBdPermanecia.LK_Alumno
                                                  join j in accesoBdPermanecia.LK_Jornada on a.Id_Jornada equals j.Id_Jornada
                                                  join s in accesoBdPermanecia.LK_Sede on a.Id_Sede equals s.Id_Sede
                                                  join c in accesoBdPermanecia.LK_Carrera on a.Id_Carrera equals c.Id_Carrera
                                                  where rut.Contains(a.Desc_Rut_Alumno) || nombre.Contains(a.Desc_Alumno) && carrera.Contains(c.Desc_Carrera)
                                                  select new AccesoFichaGlobal
                                                  {
                                                      Nombre = a.Desc_Alumno,
                                                      Rut = a.Desc_Rut_Alumno,
                                                      Carrera = c.Desc_Carrera,
                                                      Escuela = s.Desc_Sede,
                                                      Jornada = j.Desc_Jornada
                                                  }).ToList();

                    return queryBuscarInfoAlumnos; //Retorna una lista de informacion de cada alummno referente a la Tabla Global.
                }
                catch (NullReferenceException ex)
                {

                    throw;
                }
            }
        }

    }
}
