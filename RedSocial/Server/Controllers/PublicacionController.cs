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
    }
}
