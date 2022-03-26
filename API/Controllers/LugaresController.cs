using Infraestructura.Datos;
using Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LugaresController : ControllerBase
    {
        private readonly AppDbContext db;

        public LugaresController(AppDbContext db)
        {
            this.db = db;
        }

        // GET: api/<LugaresController>
        [HttpGet]
        public async Task<ActionResult<List<Lugar>>> getlugares()
        {
            var lugares = await this.db.lugar.ToListAsync();
            return Ok(lugares);
        }

        // GET api/<LugaresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lugar>> Get(int id)
        {
            return await this.db.lugar.FindAsync(id);
        }

        // POST api/<LugaresController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LugaresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LugaresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
