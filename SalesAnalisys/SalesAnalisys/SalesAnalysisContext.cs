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
            optionsBuilder.UseNpgsql("Host=localhost;Port=5434;Database=SalesAnalisys2;Username=postgres;Password=password");
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

        //var products = DataGenerator.GenerateProducts(100);
        //modelBuilder.Entity<Product>().HasData(products);
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Мягкая игрушка", Price = 35000, Total = 16, Cluster = 3 },
            new Product { Id = 2, Name = "Косметичка", Price = 22000, Total = 21, Cluster = 3 },
            new Product { Id = 3, Name = "Скатерть", Price = 24000, Total = 38, Cluster = 2 },
            new Product { Id = 4, Name = "Рюкзак", Price = 63000, Total = 20, Cluster = 1 },
            new Product { Id = 5, Name = "Подставка для телефона", Price = 40000, Total = 46, Cluster = 0 },
            new Product { Id = 6, Name = "Зажигалка", Price = 32000, Total = 35, Cluster = 0 },
            new Product { Id = 7, Name = "Радио", Price = 42000, Total = 33, Cluster = 0 },
            new Product { Id = 8, Name = "Гель для душа", Price = 17000, Total = 3, Cluster = 3 },
            new Product { Id = 9, Name = "Ножницы", Price = 21000, Total = 27, Cluster = 2 },
            new Product { Id = 10, Name = "Кольцо", Price = 34000, Total = 47, Cluster = 2 },
            new Product { Id = 11, Name = "Серьги", Price = 44000, Total = 20, Cluster = 1 },
            new Product { Id = 12, Name = "Ботинки", Price = 30000, Total = 45, Cluster = 2 },
            new Product { Id = 13, Name = "Колонка", Price = 60000, Total = 10, Cluster = 1 },
            new Product { Id = 14, Name = "Свитер", Price = 15000, Total = 22, Cluster = 2 },
            new Product { Id = 15, Name = "Вешалка", Price = 23000, Total = 25, Cluster = 2 },
            new Product { Id = 16, Name = "Лампа", Price = 17000, Total = 32, Cluster = 2 },
            new Product { Id = 17, Name = "Шоколадка", Price = 40000, Total = 18, Cluster = 3 },
            new Product { Id = 18, Name = "Молоток", Price = 28000, Total = 15, Cluster = 3 },
            new Product { Id = 19, Name = "Краска для волос", Price = 54000, Total = 18, Cluster = 1 },
            new Product { Id = 20, Name = "Печка", Price = 23000, Total = 26, Cluster = 2 },
            new Product { Id = 21, Name = "Пенал", Price = 40000, Total = 59, Cluster = 0 },
            new Product { Id = 22, Name = "Письменный стол", Price = 31000, Total = 34, Cluster = 3 },
            new Product { Id = 23, Name = "Кастрюля", Price = 18000, Total = 14, Cluster = 3 },
            new Product { Id = 24, Name = "Футбольный мяч", Price = 38000, Total = 47, Cluster = 0 },
            new Product { Id = 25, Name = "Пальто", Price = 57000, Total = 23, Cluster = 1 },
            new Product { Id = 26, Name = "Фонарик", Price = 34000, Total = 15, Cluster = 3 },
            new Product { Id = 27, Name = "Костюм", Price = 46000, Total = 5, Cluster = 1 },
            new Product { Id = 28, Name = "Компьютерная мышь", Price = 23000, Total = 8, Cluster = 3 },
            new Product { Id = 29, Name = "Вино", Price = 16000, Total = 19, Cluster = 2 },
            new Product { Id = 30, Name = "Столешница", Price = 23000, Total = 16, Cluster = 3 },
            new Product { Id = 31, Name = "Печь", Price = 46000, Total = 13, Cluster = 1 },
            new Product { Id = 32, Name = "Кольцо", Price = 53000, Total = 12, Cluster = 1 },
            new Product { Id = 33, Name = "Журнал", Price = 62000, Total = 35, Cluster = 1 },
            new Product { Id = 34, Name = "Спортивные штаны", Price = 55000, Total = 1, Cluster = 1 },
            new Product { Id = 35, Name = "Детская книга", Price = 35000, Total = 47, Cluster = 2 },
            new Product { Id = 36, Name = "Зубная щетка", Price = 15000, Total = 29, Cluster = 2 },
            new Product { Id = 37, Name = "Мыло", Price = 43000, Total = 45, Cluster = 0 },
            new Product { Id = 38, Name = "Бейсболка", Price = 42000, Total = 15, Cluster = 1 },
            new Product { Id = 39, Name = "Телефон", Price = 33000, Total = 10, Cluster = 3 },
            new Product { Id = 40, Name = "Паззл", Price = 29000, Total = 22, Cluster = 3 },
            new Product { Id = 41, Name = "Зонт", Price = 17000, Total = 6, Cluster = 3 },
            new Product { Id = 42, Name = "Гитара", Price = 26000, Total = 29, Cluster = 2 },
            new Product { Id = 43, Name = "Фляга", Price = 31000, Total = 21, Cluster = 3 },
            new Product { Id = 44, Name = "Туфли", Price = 20000, Total = 12, Cluster = 3 },
            new Product { Id = 45, Name = "Майка", Price = 18000, Total = 10, Cluster = 3 },
            new Product { Id = 46, Name = "Халат", Price = 55000, Total = 44, Cluster = 1 },
            new Product { Id = 47, Name = "Скатерть", Price = 42000, Total = 26, Cluster = 0 },
            new Product { Id = 48, Name = "Сумка для ноутбука", Price = 51000, Total = 49, Cluster = 0 },
            new Product { Id = 49, Name = "Часы", Price = 33000, Total = 31, Cluster = 3 },
            new Product { Id = 50, Name = "Шоколад", Price = 44000, Total = 12, Cluster = 1 },
            new Product { Id = 51, Name = "Косилка", Price = 44000, Total = 7, Cluster = 1 },
            new Product { Id = 52, Name = "Пыльца", Price = 42000, Total = 5, Cluster = 1 },
            new Product { Id = 53, Name = "Рамка для фото", Price = 21000, Total = 21, Cluster = 2 },
            new Product { Id = 54, Name = "Термос", Price = 20000, Total = 29, Cluster = 2 },
            new Product { Id = 55, Name = "Пылесос", Price = 49000, Total = 2, Cluster = 1 },
            new Product { Id = 56, Name = "Ветровка", Price = 56000, Total = 39, Cluster = 1 },
            new Product { Id = 57, Name = "Спальный мешок", Price = 25000, Total = 48, Cluster = 2 },
            new Product { Id = 58, Name = "Пианино", Price = 22000, Total = 28, Cluster = 2 },
            new Product { Id = 59, Name = "Сапоги", Price = 54000, Total = 16, Cluster = 1 },
            new Product { Id = 60, Name = "Косметичка", Price = 40000, Total = 43, Cluster = 0 },
            new Product { Id = 61, Name = "Зеркало", Price = 16000, Total = 31, Cluster = 2 },
            new Product { Id = 62, Name = "Подставка для ноутбука", Price = 62000, Total = 32, Cluster = 1 },
            new Product { Id = 63, Name = "Мяч", Price = 20000, Total = 21, Cluster = 2 },
            new Product { Id = 64, Name = "Подушка", Price = 45000, Total = 12, Cluster = 1 },
            new Product { Id = 65, Name = "Очки", Price = 43000, Total = 27, Cluster = 0 },
            new Product { Id = 66, Name = "Сумка", Price = 15000, Total = 31, Cluster = 2 },
            new Product { Id = 67, Name = "Браслет", Price = 30000, Total = 49, Cluster = 2 },
            new Product { Id = 68, Name = "Кружка", Price = 24000, Total = 5, Cluster = 3 },
            new Product { Id = 69, Name = "Сковорода", Price = 51000, Total = 40, Cluster = 0 },
            new Product { Id = 70, Name = "Коврик для йоги", Price = 35000, Total = 52, Cluster = 2 },
            new Product { Id = 71, Name = "Печка", Price = 55000, Total = 24, Cluster = 1 },
            new Product { Id = 72, Name = "Зонтик", Price = 35000, Total = 27, Cluster = 3 },
            new Product { Id = 73, Name = "Подушка", Price = 28000, Total = 28, Cluster = 3 },
            new Product { Id = 74, Name = "Шапка", Price = 20000, Total = 17, Cluster = 3 },
            new Product { Id = 75, Name = "Велосипед", Price = 15000, Total = 23, Cluster = 2 },
            new Product { Id = 76, Name = "Пазл", Price = 59000, Total = 38, Cluster = 1 },
            new Product { Id = 77, Name = "Пижама", Price = 23000, Total = 1, Cluster = 3 },
            new Product { Id = 78, Name = "Платье", Price = 28000, Total = 52, Cluster = 2 },
            new Product { Id = 79, Name = "Клавиатура", Price = 28000, Total = 9, Cluster = 3 },
            new Product { Id = 80, Name = "Мышь", Price = 55000, Total = 2, Cluster = 1 },
            new Product { Id = 81, Name = "Скейтборд", Price = 55000, Total = 7, Cluster = 1 },
            new Product { Id = 82, Name = "Светильник", Price = 45000, Total = 29, Cluster = 0 },
            new Product { Id = 83, Name = "Ковер", Price = 22000, Total = 10, Cluster = 3 },
            new Product { Id = 84, Name = "Книжная полка", Price = 40000, Total = 49, Cluster = 0 },
            new Product { Id = 85, Name = "Рюкзак", Price = 41000, Total = 37, Cluster = 0 },
            new Product { Id = 86, Name = "Джинсы", Price = 16000, Total = 1, Cluster = 3 },
            new Product { Id = 87, Name = "Футболка", Price = 52000, Total = 12, Cluster = 1 },
            new Product { Id = 88, Name = "Кресло", Price = 23000, Total = 28, Cluster = 2 },
            new Product { Id = 89, Name = "Стол", Price = 54000, Total = 18, Cluster = 1 },
            new Product { Id = 90, Name = "Чайник", Price = 49000, Total = 58, Cluster = 0 },
            new Product { Id = 91, Name = "Кроссовки", Price = 21000, Total = 31, Cluster = 2 },
            new Product { Id = 92, Name = "Шарф", Price = 24000, Total = 22, Cluster = 3 },
            new Product { Id = 93, Name = "Наушники", Price = 65000, Total = 13, Cluster = 1 },
            new Product { Id = 94, Name = "Планшет", Price = 64000, Total = 48, Cluster = 1 },
            new Product { Id = 95, Name = "Кофеварка", Price = 40000, Total = 1, Cluster = 1 },
            new Product { Id = 96, Name = "Фитнес-трекер", Price = 22000, Total = 13, Cluster = 3 },
            new Product { Id = 97, Name = "Смартфон", Price = 19000, Total = 18, Cluster = 2 },
            new Product { Id = 98, Name = "Ноутбук", Price = 50000, Total = 19, Cluster = 1 },
            new Product { Id = 99, Name = "Фотоаппарат", Price = 31000, Total = 33, Cluster = 3 },
            new Product { Id = 100, Name = "Книга", Price = 48000, Total = 22, Cluster = 1 }
        };

        modelBuilder.Entity<Product>().HasData(products);
    }
}
