using Microsoft.EntityFrameworkCore;
using SampleApplication.AFL;
using SampleApplication.AutoDCR_V_1;
using SampleApplication.Models;

namespace SampleApplication.Service
{
    public class CompanyRepository : IDBOperation<Company,int>
    {
        SampleContext sampleContext;
        public CompanyRepository(SampleContext _sampleContext)
        {
                sampleContext = _sampleContext;
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            var listCompany =await sampleContext.Companies.ToListAsync();
            return listCompany;
        }

        public async Task<Company> GetAsync(int id)
        {
            var companyRecord = await sampleContext.Companies.FindAsync(id);
            return companyRecord != null ? companyRecord : null;
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

        public async Task<bool> InsertAsync(Company entity)
        {
            var insertedRecord =await sampleContext.Companies.AddAsync(entity);
            var result =await sampleContext.SaveChangesAsync();
            return result > 0 ? true : false;
        }
    }
}
