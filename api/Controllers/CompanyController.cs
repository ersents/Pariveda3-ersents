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
        public void Post([FromBody] Company company)
        {
            System.Console.WriteLine(company.Name);
            CompanyUtility utility = new CompanyUtility();
            utility.SaveCompany(company);
        }

        // PUT: api/Company/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Company/5
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            Console.WriteLine(name);
            
        }
    }
}
