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
<<<<<<< HEAD
            public string? NombreRol { get; set; }
        
=======
            public string? Nombre { get; set; }
        //NombreRol
>>>>>>> 76627f2c61d12688cda2616f96f4a98c45e4f10b

    }
}

