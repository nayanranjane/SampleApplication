using SampleApplication.Models;

namespace SampleApplication.AFL
{
    public interface IDBOperation<TEntity, in Tpk> where TEntity : class
    {
        Task<bool> InsertAsync(TEntity entity);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetAsync(Tpk id);
    }
}
