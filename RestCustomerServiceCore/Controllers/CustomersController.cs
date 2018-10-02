using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCustomerServiceCore.Model;

namespace RestCustomerServiceCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private List<Customer> cList = new List<Customer>();

        // GET: api/Customers
        [HttpGet]
        public List<Customer> Get()
        {
            cList.Add(new Customer(1, "Customer1", "LastName1", 1992));
            cList.Add(new Customer(2, "Customer2", "LastName2", 1993));
            cList.Add(new Customer(3, "Customer3", "LastName3", 1994));
            //return new string[] { "value1", "value2" };
            return cList;
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customers
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
