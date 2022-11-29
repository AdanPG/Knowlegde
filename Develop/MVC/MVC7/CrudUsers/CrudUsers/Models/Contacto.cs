using System.ComponentModel.DataAnnotations;

namespace CrudUsers.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="You must provide a Name")]
        public string Nombre { get; set; }
       
        public string Telefono { get; set; }
        
        public string EMail { get; set; }

        public string FechaCreacion { get; set; }

    }
}
