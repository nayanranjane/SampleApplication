using SampleApplication.Models;

namespace SampleApplication.AFL
{
    public interface IDBOperation
    {
        Task<bool> InsertAsync(CompanyDTO company);
    }
}
