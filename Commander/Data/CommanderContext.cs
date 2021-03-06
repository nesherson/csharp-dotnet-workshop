using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

using Commander.Models;


#nullable disable

namespace Commander.Data
{
    public partial class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Command> Commands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_United States.1252");

            modelBuilder.Entity<Command>(entity =>
            {
                entity.ToTable("commands");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HowTo).HasColumnName("how_to");

                entity.Property(e => e.Line).HasColumnName("line");

                entity.Property(e => e.Platform).HasColumnName("platform");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
