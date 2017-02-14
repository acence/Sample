namespace Sample.Logic.Base
{
    using AutoMapper;
    using Database.Models.Base;
    using Database.Repositories.Interfaces;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TransferModels.Base;
    using System.Data.Entity;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Repository interface type</typeparam>
    /// <typeparam name="U">Database model type</typeparam>
    /// <typeparam name="V">Dto model type</typeparam>
    public class BaseLogic<T, U, V> : IBaseLogic<V> 
        where U : BaseModel
        where V : BaseDto
        where T : IBaseRepository<U>
    {
        public readonly T _db;
        public readonly IMapper _mapper;

        public BaseLogic(T db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<V>> GetAll()
        {
            var data = _db.Select();
            return _mapper.Map<List<V>>(await data.ToListAsync());
        }

        public async Task<Int32> Insert(V item)
        {
            return await _db.Insert(_mapper.Map<U>(item));
        }
        public async Task<Int32> Update(V item)
        {
            return await _db.Update(_mapper.Map<U>(item));
        }
        public async Task<Int32> Delete(V item)
        {
            return await _db.Delete(_mapper.Map<U>(item));
        }
    }
}
