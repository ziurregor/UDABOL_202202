using Microsoft.EntityFrameworkCore;

namespace EntityPosgardo.modelo.Seeding
{
    public class Seeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // imgresra valores de Roles
            var administracion = new Roles { RolesId = 1, Cargo = "admin" };
            var prueba = new Roles { RolesId = 2, Cargo = "Prueba" };
            var escritor = new Roles { RolesId = 3, Cargo = "escritor" };
            var lector = new Roles { RolesId = 4, Cargo = "lector" };
            modelBuilder.Entity<Roles>().HasData(administracion,prueba, escritor, lector);


           
        }
    }
}
