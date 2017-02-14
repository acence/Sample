namespace Sample.Database.Infrastructure
{
    using Models.Base;
    using System;
    using System.Data.Entity;
    using System.Threading.Tasks;

    public interface IDatabaseContext
    {

        IDbSet<T> Set<T>() where T : BaseModel;
        Int32 SaveChanges();
        Task<Int32> SaveChangesAsync();
    }
}
