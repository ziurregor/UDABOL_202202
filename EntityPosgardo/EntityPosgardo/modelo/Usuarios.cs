namespace EntityPosgardo.modelo
{
    public class Usuarios
    {
        public int UsuariosId { get; set; }
        public string nombre { get; set; }
        public string Detalle { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public bool estado { get; set; }
        public Roles Roles { get; set; }
        public HashSet<Mensajes> Mensajes { get; set; }

    }
}
