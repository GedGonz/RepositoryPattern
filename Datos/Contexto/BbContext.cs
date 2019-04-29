using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contexto
{
    public class BbContext:DbContext
    {
        public BbContext():base("name=BDContext")
        {

        }

        public DbSet<Persona> Persona { get; set; }
    }
}
