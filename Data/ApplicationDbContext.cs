using Microsoft.EntityFrameworkCore;

namespace NeperiaDizionarioV2.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Parola> Parola { get; set; }
        public virtual DbSet<Sinonimo> Sinonimi { get; set; }
        public virtual DbSet<Elabor> Elabors { get; set; }
        public virtual DbSet<ParolaTrovata> ParolaTrovata { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    }
}