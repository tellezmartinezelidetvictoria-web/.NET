using System.ComponentModel.DataAnnotations;

namespace CRUD_NET7_MVC.models
{
    public class Contacto
    {

        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Telefono es requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Movil es requerido")]
        public string Movil { get; set; }
        [Required(ErrorMessage = "El Email es requerido")]
        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
