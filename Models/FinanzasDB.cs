using Microsoft.EntityFrameworkCore;

namespace FinanzasAPI.Models
{
    public class FinanzasDB : DbContext
    {
        public FinanzasDB() { }
        public FinanzasDB(DbContextOptions<FinanzasDB> options) : base(options) { }

        public DbSet<TasaCambio> TasaCambio { get; set; }
        public DbSet<SaludFinanciera> SaludFinanciera { get; set; }
        public DbSet<Inflacion> Inflacion { get; set; }
        public DbSet<HistorialCrediticio> HistorialCrediticio { get; set; }
        public DbSet<ReporteWebService> ReporteWebService { get; set; }
    }
}
