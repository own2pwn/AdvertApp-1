using System;
using Common.CommonClasses;
using Data.Repositories.Interfaces;

namespace Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Load(int id)
        {
            throw new NotImplementedException();
        }

        public Result Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
