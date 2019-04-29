using Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Contratos;

namespace Dominio.Dominio
{
    public class PersonaDominio : IPersonaDominio
    {
        protected readonly IPersonaRepositorio personaRepositorio;
        public PersonaDominio(IPersonaRepositorio personaRepositorio)
        {
            this.personaRepositorio = personaRepositorio;
        }
        public IEnumerable<Persona> ListaPerson()
        {
            return personaRepositorio.ListaPerson();
        }
    }
}
