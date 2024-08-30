using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Model;
using TestApi.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Patient : ControllerBase
    {
        private IPatient patient  = new PatientRepository();

        // GET: api/<Patient>
        [HttpGet]
        public IEnumerable<Model.Patient> Get()
        {
            return patient.GetAllPatient();
        }

        // GET api/<Patient>/5
        [HttpGet("{id}")]
        public Model.Patient Get(int id)
        {
            return patient.GetPatient(id);
        }



        // POST api/<Patient>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<Patient>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<Patient>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
