using Microsoft.EntityFrameworkCore;
using SampleApplication.AFL;
using SampleApplication.AutoDCR_V_1;

namespace SampleApplication.Service
{
    public class EmployeeService : IDBOperation<Employee, int>
    {
        SampleContext sampleContext;
        public EmployeeService(SampleContext _sampleContext)
        {
            sampleContext = _sampleContext;
        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            var listOfEmployees = await sampleContext.Employees.ToListAsync();
            return listOfEmployees;
        }

        public Task<Employee> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(Employee entity)
        {
            var insertedEmployee  = await sampleContext.Employees.AddAsync(entity);
            var result = await sampleContext.SaveChangesAsync();
            return result>0?true:false;
        }
    }
}
