using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class EmpleadosDb : DbContext
    {
        public EmpleadosDb() : base("name = Persona")
        {

        }
        
        public DbSet<Empleado>
    }
}
