using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UniversiteDbContext : DbContext
    {

        public UniversiteDbContext() : base("cstr")
        {

        }
        //
        public DbSet<Universite> Universiteler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent Api
            modelBuilder.Entity<Universite>().ToTable("tblUniversite");

            modelBuilder.Entity<Universite>().Property(o => o.UniversiteAD).HasMaxLength(50).IsRequired().HasColumnType("varchar");
            //modelBuilder.Entity<Universite>().Property(o => o.Bolum.B).HasMaxLength(75).IsRequired().HasColumnType("varchar");

        }
    }
}