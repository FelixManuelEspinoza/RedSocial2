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

        public async Task<ActionResult<List<Publicacion>>> Get()
        {
            return await dBcontext.PuBlicaciones.ToListAsync();
        }
    }
}
