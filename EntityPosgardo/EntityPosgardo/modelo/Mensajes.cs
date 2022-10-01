using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityPosgardo.modelo
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
