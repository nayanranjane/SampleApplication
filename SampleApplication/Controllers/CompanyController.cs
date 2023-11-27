using Microsoft.AspNetCore.Mvc;
using SampleApplication.AFL;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class CompanyController : Controller
    {
        IDBOperation dBOperation;
        public CompanyController(IDBOperation dBOperation)
        {
            this.dBOperation = dBOperation;
        }
        public async Task<IActionResult> AddCompany()
        {
            CompanyDTO companyDTO = new CompanyDTO()
            {
                CompanyName = "Softtech",
                CompanyLocation ="abc",
                CompanyWebsite = "Abc.com"
            };
            var result  = await dBOperation.InsertAsync(companyDTO);
            return Ok(result);
        }
    }
}
