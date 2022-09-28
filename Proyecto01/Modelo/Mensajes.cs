using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class Mensajes
    {
        [Key]
        [Column("MensajeId")]
        public int MensajeId { get; set; }
        public int UseridId { get; set; }
        public string? Mensaje { get; set; }
    }
}

