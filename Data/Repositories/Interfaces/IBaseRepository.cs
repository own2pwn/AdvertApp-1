using Common.CommonClasses;

namespace Data.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        T Load(int id);

        Result Save(T entity);

        Result Delete(int id);
    }
}
