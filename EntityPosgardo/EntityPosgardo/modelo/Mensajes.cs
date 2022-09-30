namespace EntityPosgardo.modelo
{
    public class Mensajes
    {
        public int MensajeId { get; set; }
        public string MensajesXml { get; set; }
        public bool estado { get; set; }
        public Usuarios Usuarios { get; set; }
    }
}
