using Texnicum.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Texnicum.Models
{
    public class AppCtx : IdentityDbContext<User>
    {
        public AppCtx(DbContextOptions<AppCtx> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FormOfStudy> FormsOfStudy { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Disciplines> Disciplines { get; set; }
        public DbSet<TypesOfTotals> TypesOfTotals { get; set; }
    }
}