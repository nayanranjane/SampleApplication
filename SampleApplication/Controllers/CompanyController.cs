using Microsoft.AspNetCore.Mvc;
using SampleApplication.AFL;
using SampleApplication.AutoDCR_V_1;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class CompanyController : Controller
    {
        IDBOperation<Company,int> dBOperation;
        public CompanyController(IDBOperation<Company, int> dBOperation)
        {
            this.dBOperation = dBOperation;
        }
        public async Task<IActionResult> AddCompany(int id)
        {
            //Company companyDTO = new Company()
            //{
            //    CompanyName = "Abc",
            //    CompanyLocation ="abc",
            //    CompanyWebsite = "Abc.com"
            //};
            var result  = await dBOperation.GetAsync(id);
            return Ok(result);
        }
    }
}
