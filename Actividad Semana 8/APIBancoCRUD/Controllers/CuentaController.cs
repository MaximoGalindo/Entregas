using BancoSLN;
using DataAPI.DataHttp;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBancoCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        private IDataLib dataApi;

        public CuentaController()
        {
            dataApi = new DataLib();        
        }

        // GET: api/<CuentaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CuentaController>/5
        [HttpGet("{dni}")]
        public IActionResult GetCuentas(int dni)
        {
            List<Cuenta> lCuentas = null;
            try
            {
                lCuentas = dataApi.GetCuentas(dni);
                return Ok(lCuentas);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // POST api/<CuentaController>
        [HttpPost("/cuenta")]
        public IActionResult PostCuentas(Cuenta cuenta)
        {
            try
            {
                if (cuenta == null)
                    BadRequest("Datos de la cuenta incorrectos");

                return Ok(dataApi.CrearCuenta(cuenta));
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        // PUT api/<CuentaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CuentaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
