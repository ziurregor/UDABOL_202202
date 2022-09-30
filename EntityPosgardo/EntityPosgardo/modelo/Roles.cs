using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityPosgardo.modelo
{
    public class Roles
    {
        [Key]
        public int RolesId { get; set; }
        public string Cargo { get; set; }
        public bool estado { get; set; }
        public HashSet<Usuarios> Usuarios { get; set; }

    }

}
