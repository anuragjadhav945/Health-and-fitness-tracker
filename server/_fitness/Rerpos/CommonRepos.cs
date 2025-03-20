using _fitness.dataContext;
using _fitness.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _fitness.Rerpos
{
    public class CommonRepos<T> : commoninterface<T> where T : class
    {
        private readonly _dataContext _dbConnect;
        private readonly DbSet<T> _totables;
        public CommonRepos(_dataContext context)
        {
            _dbConnect = context;
            _totables = _dbConnect.Set<T>();
        }

        public async Task<bool> createUsers(T _model)
        {
            try
            {
                if(_model != null)
                {
                    _totables.AddAsync(_model);
                    await _dbConnect.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> deleteData(Expression<Func<T, bool>> _userId)
        {
            try
            {
                var _res = await _totables.FindAsync(_userId);
                if( _res != null)
                {
                    _totables.Remove(_res);
                    _dbConnect.SaveChangesAsync();
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<T>> getAllInfo()
        {
            try
            {
                var dt = await _totables.ToListAsync();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }           
        }

        public async Task<List<T>> getInfo(Expression<Func<T, bool>> _userId)
        {
            try
            {
                return await _totables.Where(_userId).ToListAsync();               

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
