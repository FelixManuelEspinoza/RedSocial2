using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDRedSocial.Data.Entity
{
    public class Publicacion
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        [MaxLength(500)]
        public string Texto { get; set; }

        public byte[] Imagen { get; set; }

        public string FormatoImagen { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public string UsuarioId { get; set; }

        public Trabajador Autor { get; set; }
    }
}
