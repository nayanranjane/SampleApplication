using SampleApplication.AFL;
using SampleApplication.AutoDCR_V_1;
using SampleApplication.Models;

namespace SampleApplication.Service
{
    public class CompanyRepository : IDBOperation
    {
        SampleContext sampleContext;
        public CompanyRepository(SampleContext _sampleContext)
        {
                sampleContext = _sampleContext;
        }
        public async Task<bool>InsertAsync(CompanyDTO companyDto)
        {
            Company company = new Company()
            {
                CompanyName = companyDto.CompanyName,
                CompanyLocation = companyDto.CompanyLocation,
                CompanyWebsite = companyDto.CompanyWebsite

            };
            await sampleContext.Companies.AddAsync(company);
            var result = await sampleContext.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
