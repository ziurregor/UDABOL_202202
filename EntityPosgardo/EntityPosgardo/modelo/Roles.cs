using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityPosgardo.modelo
{
    public class Roles
    {
        [Key]
        [Column("RolId")]
        public int RolId { get; set; }
        public string? Nombre { get; set; }

    }

}
