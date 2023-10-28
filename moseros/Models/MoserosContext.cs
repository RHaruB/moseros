using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace moseros.Models;

public partial class MoserosContext : DbContext
{
    public MoserosContext()
    {
    }

    public MoserosContext(DbContextOptions<MoserosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Amante> Amantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=RH;Database=moseros;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Amante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__amantes__3214EC27DD4344CB");

            entity.ToTable("amantes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Algo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("algo");
            entity.Property(e => e.Edad)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("edad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
