using Contratos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Datos.Contexto;

namespace Datos.Repositorios
{
    public class PersonaRepositorio : BaseRepositorio<Persona>, IPersonaRepositorio
    {

        public PersonaRepositorio() : base(new BbContext())
        {

        }

        public IEnumerable<Persona> ListaPerson()
        {
            return DbTabla.ToList();
        }
    }
}
