using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using SalesAnalisys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SalesAnalysis;

public class SalesAnalysisContext : DbContext
{
    public SalesAnalysisContext() { }
    public SalesAnalysisContext(DbContextOptions<SalesAnalysisContext> options)
        : base(options) { }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5434;Database=SalesAnalisys;Username=postgres;Password=password");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            entityType.SetTableName(entityType.DisplayName());
        }

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(st => st.Id);

            entity.Property(e => e.Name)
            .HasMaxLength(255);

        });

        var products = DataGenerator.GenerateProducts(100);
        modelBuilder.Entity<Product>().HasData(products);
    }
}
