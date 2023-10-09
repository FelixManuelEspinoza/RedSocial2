using BDRedSocial;
using BDRedSocial.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RedSocial.Server.Controllers
{
    [ApiController]
    [Route("api/Trabajador")]
    public class TrabajadorController: ControllerBase
    {
        private readonly DBcontext dBcontext;

        public TrabajadorController(DBcontext dBcontext)
        {
            this.dBcontext = dBcontext;
        }

        [HttpGet]

        public async Task<ActionResult<List<Trabajador>>> Get()
        {
            return await dBcontext.Trabajadores.ToListAsync();
        }

        [HttpPost]

        public async Task<ActionResult<int>> Post(Trabajador trabajador)
        {
            dBcontext.Add(trabajador);
            await dBcontext.SaveChangesAsync();
            return trabajador.Id;




        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Trabajador trabajador, int id)
        {
            if (id != trabajador.Id)
            {
                return BadRequest("El id del trabajador no corresponde.");
            }

            var existe = await dBcontext.Trabajadores.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound($"el Trabajador de id={id} no existe");
            }

            dBcontext.Update(trabajador);
            await dBcontext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await dBcontext.Trabajadores.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound($"El trabajador de id={id} no existe");
            }
            Trabajador pepe = new Trabajador();
            pepe.Id = id;

            dBcontext.Remove(pepe);

            await dBcontext.SaveChangesAsync();

            return Ok();
        }

    }
}
