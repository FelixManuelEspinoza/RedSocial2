using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDRedSocial.Data.Entity
{
    public class Trabajador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(20, ErrorMessage = "Solo se aceptan hasta 20 caracteres en el nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es requerido")]
        [MaxLength(20, ErrorMessage = "Solo se aceptan hasta 20 caracteres en el nombre")]
        public string Apellido { get; set; }
        

        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(20, ErrorMessage = "Solo se aceptan hasta 20 caracteres en el nombre")]
        public string Puesto { get; set; }


        public ICollection<Publicacion> Publicaciones { get; set; } = new List<Publicacion>();
    }
}

