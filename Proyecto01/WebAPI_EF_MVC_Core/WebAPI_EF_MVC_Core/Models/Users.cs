using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_EF_MVC_Core.Models
{
    public class Users
    {
        [Key]
        [Column("UserId")]
        public int UserId { get; set; }
        public string Usuario { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Edad { get; set; }
        public string Contraseña { get; set; }
    }
}

