using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        // GET: api/Company
        [HttpGet]
        
        public List<Company> Get()
        {
            List<Company> companies = new List<Company>();
            // Company myCompany = new Company();
            // myCompany.Name = "Disney";
            // myCompany.Ticker = "DISN";
            // myCompany.SharePrice = 5.00;

            // Company yourCompany = new Company();
            // yourCompany.Name = "Apple";
            // yourCompany.Ticker = "APPL";
            // yourCompany.SharePrice = 5.00;

            // companies.Add(myCompany);
            // companies.Add(yourCompany);

            // return companies;

            CompanyUtility utility = new CompanyUtility(companies);
            utility.GetAllCompanies();
            return companies;
        }
       

        // GET: api/Company/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Company
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Company/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Company/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
