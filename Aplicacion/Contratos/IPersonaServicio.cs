using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Contratos
{
    public interface IPersonaServicio
    {
        bool add(Persona entidad);
        List<Persona> ListAll();
        IEnumerable<Persona> ListFiler(Expression<Func<Persona, bool>> predicado);
    }
}
