using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    public interface IBaseRepositorio<T> where T: class
    {
        bool add(T entidad);
        IEnumerable<T> ListAll();
        IEnumerable<T> ListFiler(Expression<Func<T, bool>> predicado);
    }
}
