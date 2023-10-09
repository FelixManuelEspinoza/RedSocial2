using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.Shared.DTO
{
    internal class PublicacionDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string FormatoImagen { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int AutorId { get; set; } 
    }
}
