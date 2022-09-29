using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class Roles
    {
            [Key]
            [Column("RolId")]
            public int RolId{ get; set; }
            public string? Nombre { get; set; }
        //NombreRol

    }
}

