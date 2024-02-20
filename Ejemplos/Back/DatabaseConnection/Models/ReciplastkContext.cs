using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseConnection.Models;

public partial class ReciplastkContext : DbContext
{
    public ReciplastkContext()
    {
    }

    public ReciplastkContext(DbContextOptions<ReciplastkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Secondarytabletest> Secondarytabletests { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=reciplastk.cty0a2ewmeb5.us-east-1.rds.amazonaws.com;Database=Reciplastk;Username=postgres;Password=Admin123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Productid).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Buyprice).HasColumnName("buyprice");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.Creationdate)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creationdate");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Isactive)
                .HasDefaultValue(true)
                .HasColumnName("isactive");
            entity.Property(e => e.Issubtype).HasColumnName("issubtype");
            entity.Property(e => e.Margin).HasColumnName("margin");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Sellprice).HasColumnName("sellprice");
            entity.Property(e => e.Updatedate)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<Secondarytabletest>(entity =>
        {
            entity.HasKey(e => e.Secondarytabletestid).HasName("secondarytabletest_pkey");

            entity.ToTable("secondarytabletest");

            entity.Property(e => e.Secondarytabletestid).HasColumnName("secondarytabletestid");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Isactive)
                .HasDefaultValue(true)
                .HasColumnName("isactive");
            entity.Property(e => e.Testid).HasColumnName("testid");

            entity.HasOne(d => d.Test).WithMany(p => p.Secondarytabletests)
                .HasForeignKey(d => d.Testid)
                .HasConstraintName("secondarytabletest_testid_fkey");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity.HasKey(e => e.Testid).HasName("test_pkey");

            entity.ToTable("test");

            entity.Property(e => e.Testid).HasColumnName("testid");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
