using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class Mensajes
    {
        [Key]
        [Column("MensajeId")]
        public int MensajeId { get; set; }
        public Users? Remitente { get; set; }
        public List<Users>? Destinatario { get; set; }
        public string? Mensaje { get; set; }
        public DateTime Fecha { get; set; }
    }
}

