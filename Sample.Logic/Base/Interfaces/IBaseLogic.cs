using Sample.Logic.TransferModels.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Logic.Base.Interfaces
{
    public interface IBaseLogic<T>
        where T : BaseDto
    {
        Task<IEnumerable<T>> GetAll();
        Task<Int32> Insert(T entity);
        Task<Int32> Update(T entity);
        Task<Int32> Delete(T entity);
    }
}
