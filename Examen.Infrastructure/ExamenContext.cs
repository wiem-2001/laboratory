using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure
{
    public class ExamenContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Laboratoire> Laboratoires { get; set; }
        public DbSet<Infirmier> Infirmiers { get; set; }
        public DbSet<Analyse> Analyses { get; set; }
        public DbSet<Bilan> Bilans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\LaboWiemBenMansour;
                                 Initial Catalog=LaboWiemBenMansour;
                                 Integrated Security=true;
                                 MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Laboratoire>()
                        .Property(l => l.localisation)
                        .HasColumnName("AdresseLabo")
                        .HasMaxLength(50);

          
            modelBuilder.ApplyConfiguration(new BilanConfiguration());
        }
    }
}
