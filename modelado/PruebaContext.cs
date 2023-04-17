﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cooperativa_Julian_vega_felix.modelado;

public partial class PruebaContext : DbContext
{
    public PruebaContext()
    {
    }

    public PruebaContext(DbContextOptions<PruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Entrega> Entregas { get; set; }

    public virtual DbSet<Marisco> Mariscos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Trabajadore> Trabajadores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-U15LF2GP;Database=prueba;Integrated Security=true; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdm).HasName("PK__admins__3E0FA4ADE76AF944");

            entity.ToTable("admins");

            entity.Property(e => e.IdAdm).HasColumnName("idAdm");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Entrega>(entity =>
        {
            entity.HasKey(e => e.IdEnt).HasName("PK__entrega__3F17F22B7E320961");

            entity.ToTable("entrega");

            entity.Property(e => e.IdEnt).HasColumnName("idEnt");
            entity.Property(e => e.FecEnt)
                .HasColumnType("date")
                .HasColumnName("fecEnt");
            entity.Property(e => e.IdMar).HasColumnName("idMar");
            entity.Property(e => e.IdTra).HasColumnName("idTra");
            entity.Property(e => e.PesTot)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pesTot");

            entity.HasOne(d => d.IdMarNavigation).WithMany(p => p.Entregas)
                .HasForeignKey(d => d.IdMar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__entrega__idMar__2C3393D0");

            entity.HasOne(d => d.IdTraNavigation).WithMany(p => p.Entregas)
                .HasForeignKey(d => d.IdTra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__entrega__idTra__2D27B809");
        });

        modelBuilder.Entity<Marisco>(entity =>
        {
            entity.HasKey(e => e.IdMar).HasName("PK__mariscos__3DC6CB1E3A781052");

            entity.ToTable("mariscos");

            entity.Property(e => e.IdMar).HasColumnName("idMar");
            entity.Property(e => e.TipMariscos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipMariscos");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__persona__3213E83F696957C0");

            entity.ToTable("persona");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Trabajadore>(entity =>
        {
            entity.HasKey(e => e.IdTra).HasName("PK__trabajad__020F13874C9303E7");

            entity.ToTable("trabajadores");

            entity.Property(e => e.IdTra).HasColumnName("idTra");
            entity.Property(e => e.ApelTra)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("apelTra");
            entity.Property(e => e.Curp)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("CURP");
            entity.Property(e => e.NomTra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nomTra");
            entity.Property(e => e.Rfc)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("RFC");
            entity.Property(e => e.TelTra)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telTra");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
