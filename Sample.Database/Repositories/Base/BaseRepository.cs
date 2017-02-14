namespace Sample.Database.Repositories.Base
{
    using Infrastructure;
    using Interfaces;
    using Models.Base;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly IDatabaseContext _context;
        private IDbSet<T> _entities;

        public BaseRepository(IDatabaseContext context)
        {
            _context = context;
        }

        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<T>();
                return _entities;
            }
        }

        public virtual IQueryable<T> Select()
        {
            return Entities;
        }

        public virtual async Task<Int32> Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            Entities.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<Int32> Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            return await _context.SaveChangesAsync();
        }

        public virtual async Task<Int32> Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            Entities.Add(entity);
            return await _context.SaveChangesAsync();
        } 
    }
}
