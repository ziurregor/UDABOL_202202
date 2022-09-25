using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class Users
    {
        [Key]
        [Column("UserId")]
        public int UserId { get; set; }
        public string? Usuario { get; set; }
<<<<<<< HEAD
        public string? Nombre { get; set; }
        public bool IsActive { get; set; }
=======
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public int Edad { get; set; }
>>>>>>> 76627f2c61d12688cda2616f96f4a98c45e4f10b
        public string? Contraseña { get; set; }
    }
}

