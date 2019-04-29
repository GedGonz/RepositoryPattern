using Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Datos.Repositorios
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {

        protected readonly DbContext contexto;
        protected readonly DbSet<T> DbTabla;

        public BaseRepositorio(DbContext contexto)
        {
            this.contexto = contexto;
            this.DbTabla = contexto.Set<T>();
        }
        public bool add(T entidad)
        {
            DbTabla.Add(entidad);
            return true;
        }

        public IEnumerable<T> ListAll()
        {
            return DbTabla.ToList();
        }

        public IEnumerable<T> ListFiler(Expression<Func<T, bool>> predicado)
        {
            return DbTabla.Where(predicado);
        }
    }
}
