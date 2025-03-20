using System.Linq.Expressions;

namespace _fitness.Interfaces
{
    public interface commoninterface <T>
    {
        public Task<bool> createUsers(T _model);
        public Task<List<T>> getInfo(Expression<Func<T,bool>> _userId);
        public Task<List<T>> getAllInfo();
        public Task<bool> deleteData(Expression<Func<T, bool>> _userId);

    }
}
