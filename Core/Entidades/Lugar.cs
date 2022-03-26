using System.ComponentModel.DataAnnotations;

namespace Core.Entidades
{
    public class Lugar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
       

    }
}
