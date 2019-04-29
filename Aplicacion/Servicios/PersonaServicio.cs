using Aplicacion.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Linq.Expressions;
using Dominio.Contrato;

namespace Aplicacion.Servicios
{
    public class PersonaServicio : IPersonaServicio
    {
        protected readonly IPersonaDominio personaDominio;
        public PersonaServicio(IPersonaDominio personaDominio)
        {
            this.personaDominio = personaDominio;
        }
        public bool add(Persona entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> ListAll()
        {
            return personaDominio.ListaPerson();
        }

        public IEnumerable<Persona> ListFiler(Expression<Func<Persona, bool>> predicado)
        {
            throw new NotImplementedException();
        }
    }
}
