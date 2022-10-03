using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api
{
    public class WeatherForecast
    {
        /*
               public DateTime Date { get; set; }

               public int TemperatureC { get; set; }

               public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

               public string Summary { get; set; }*/
        [Key]
        [Column("MensajeId")]
        public int MensajeId { get; set; }
        public int UseridId { get; set; }
        public string? Mensaje { get; set; }
    }
}
