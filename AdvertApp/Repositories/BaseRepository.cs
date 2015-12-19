using System;
using AdvertApp.CommonClasses;
using AdvertApp.Repositories.Interfaces;

namespace AdvertApp.Repositories
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
