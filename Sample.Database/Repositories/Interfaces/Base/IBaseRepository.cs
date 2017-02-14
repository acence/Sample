namespace Sample.Database.Repositories.Interfaces
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IBaseRepository<T>
    {
        IQueryable<T> Select();
        Task<Int32> Insert(T entity);
        Task<Int32> Update(T entity);
        Task<Int32> Delete(T entity);
    }
}
