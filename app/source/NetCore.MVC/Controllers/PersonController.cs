using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCore.MVC.Models;

namespace NetCore.MVC.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        // GET: api/Person
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Person
        [HttpPost]
        public void Post(PersonModel person)
        {
            
        }
        
        // PUT: api/Person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PersonModel person)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
