using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using BusinessLogicModel;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<BLMCliente> Get()
        {
            BLCliente blCliente = new BLCliente();
            return blCliente.ListarClientes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public BLMCliente Get(int id)
        {
            BLCliente blCliente = new BLCliente();
            return blCliente.Buscar(id);
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
