using BDRedSocial;
using BDRedSocial.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RedSocial.Server.Controllers
{
    [ApiController]
    [Route("api/Publicacion")]
    public class PublicacionController : ControllerBase
    {
        private readonly DBcontext dBcontext;

        public PublicacionController(DBcontext dBcontext)
        {
            this.dBcontext = dBcontext;
        }

        [HttpGet]

        public async Task<ActionResult<List<Publicacion>>> Get() 
        {
            return await dBcontext.PuBlicaciones.ToListAsync();
        }

        [HttpPost]

        public async Task<ActionResult<int>> Post(Publicacion publicacion)
        {
            dBcontext.Add(publicacion);
            await dBcontext.SaveChangesAsync();
            return publicacion.Id;
            



        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Publicacion publicacion, int id)
        {
            if (id != publicacion.Id)
            {
                return BadRequest("El id de la Publicacion no corresponde.");
            }

            var existe = await dBcontext.PuBlicaciones.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound($"La Publicacion de id={id} no existe");
            }

            dBcontext.Update(publicacion);
            await dBcontext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await dBcontext.PuBlicaciones.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound($"La Especialidad de id={id} no existe");
            }
            Publicacion pepe = new Publicacion();
            pepe.Id = id;

            dBcontext.Remove(pepe);

            await dBcontext.SaveChangesAsync();

            return Ok();
        }

    }
}
