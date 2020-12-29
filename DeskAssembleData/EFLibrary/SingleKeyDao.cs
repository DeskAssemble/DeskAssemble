using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData.EFLibrary
{
    public abstract class SingleKeyDao<T, K> : BaseDao<T> where T : class
    {
        public T GetByPK(K key)
        {
            using (DbContext context = DbContextCreator.Create())
            {
                return context.Set<T>().Find(key);
            }
        }

        public void DeleteByPK(K key)
        {
            T entity = GetByPK(key);

            if (entity != null)
                Delete(entity);
        }

        public K GetMaxKey()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = context.Set<T>()
                    .OrderByDescending(KeySelector)
                    .Select(KeySelector);

                return query.FirstOrDefault();
            }
        }

        protected abstract Expression<Func<T, K>> KeySelector { get; }
    }
}
