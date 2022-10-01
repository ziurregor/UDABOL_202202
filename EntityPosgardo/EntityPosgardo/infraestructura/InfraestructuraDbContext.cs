using EntityPosgardo.modelo;
using EntityPosgardo.modelo.Seeding;
using Microsoft.EntityFrameworkCore;

namespace EntityPosgardo.infraestructura
{
    public class InfraestructuraDbContext : DbContext
    {
        internal object Roles;

        public InfraestructuraDbContext(DbContextOptions<InfraestructuraDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Mensajes>().HasKey(Llave_Pk => Llave_Pk.MensajeId);


            //agregar datos a travez de Seeding 
            Seeding.Seed(modelBuilder);


            /*
            //definir llave primaria
            modelBuilder.Entity<Roles>().HasKey(Llave_Pk => Llave_Pk.RolesId);
            //cambiar los valores de la colunna .HasColumnName("Roles")
            modelBuilder.Entity<Roles>().Property(Colun_cargo => Colun_cargo.Cargo)
                .HasMaxLength(150).IsRequired();
            //cambiar nombre a la taba
            //modelBuilder.Entity<Roles>().ToTable(name: "Cargo", schema:"posgrado");


            modelBuilder.Entity<Usuarios>().HasKey(Llave_Pk => Llave_Pk.UsuariosId);
            modelBuilder.Entity<Usuarios>().Property(colun_Naciminento => colun_Naciminento.FechaNacimiento)
                .HasColumnType("Date");

            modelBuilder.Entity<Mensajes>().HasKey(Llave_Pk => Llave_Pk.MensajeId);

            */

        }
        public DbSet<Roles> Cargo { get; set; }
        public DbSet<Usuarios> usuario { get; set; }
        public DbSet<Mensajes> Mensaje { get; set; }
    }
}
