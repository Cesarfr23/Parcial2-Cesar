using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class EmpleadosBll
    {
        public static bool Insertar(Empleados empleado)
        {
            bool retorno = false;
            try
            {
                using (var database = new EmpleadosDb())
                {
                    database.Empleados.Add(empleado);
                    database.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }

        public static Empleados Buscar(int IdEmpleado)
        {
            var database = new EmpleadosDb();

            return database.Empleados.Find(IdEmpleado);

        }

        public static List<Empleados> GetLista()
        {
            List<Empleados> lista = new List<Empleados>();

            var database = new EmpleadosDb();

            lista = database.Empleados.ToList();

            return lista;

        }
    }
