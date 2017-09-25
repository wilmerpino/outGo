using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using outGo.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace outGo.Controllers
{
    [Route("api/[controller]")]
    public class FacturasController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Facturas> Get()
        {
            try
            {
                using (var db = new outGoEntities())
                {
                    
                    var facturas = db.facturas
                        .Include(c => c.comercios)
                        .Include(c => c.detalles)
                        .ToList();

                    return facturas;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
