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
        private string _connectionString = null;

        public CommanderContext(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public CommanderContext(DbContextOptions<CommanderContext> options)
            : base(options)
        {
        }

        public IConfiguration Configuration { get; }


        public virtual DbSet<Command> Commands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _connectionString = Configuration["Commander:ConnectionString"];

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_connectionString);
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
