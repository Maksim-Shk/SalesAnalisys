﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SalesAnalysis;

#nullable disable

namespace SalesAnalisys.Migrations
{
    [DbContext(typeof(SalesAnalysisContext))]
    partial class SalesAnalysisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SalesAnalysis.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Cluster")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<double>("Total")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 99900,
                            Cluster = 0,
                            Name = "Книга",
                            Price = 48000.0,
                            Total = 22.0
                        },
                        new
                        {
                            Id = 99899,
                            Cluster = 0,
                            Name = "Фотоаппарат",
                            Price = 31000.0,
                            Total = 33.0
                        },
                        new
                        {
                            Id = 99898,
                            Cluster = 0,
                            Name = "Ноутбук",
                            Price = 50000.0,
                            Total = 19.0
                        },
                        new
                        {
                            Id = 99897,
                            Cluster = 0,
                            Name = "Смартфон",
                            Price = 19000.0,
                            Total = 18.0
                        },
                        new
                        {
                            Id = 99896,
                            Cluster = 0,
                            Name = "Фитнес-трекер",
                            Price = 22000.0,
                            Total = 13.0
                        },
                        new
                        {
                            Id = 99895,
                            Cluster = 0,
                            Name = "Кофеварка",
                            Price = 40000.0,
                            Total = 1.0
                        },
                        new
                        {
                            Id = 99894,
                            Cluster = 0,
                            Name = "Планшет",
                            Price = 64000.0,
                            Total = 48.0
                        },
                        new
                        {
                            Id = 99893,
                            Cluster = 0,
                            Name = "Наушники",
                            Price = 65000.0,
                            Total = 13.0
                        },
                        new
                        {
                            Id = 99892,
                            Cluster = 0,
                            Name = "Шарф",
                            Price = 24000.0,
                            Total = 22.0
                        },
                        new
                        {
                            Id = 99891,
                            Cluster = 0,
                            Name = "Кроссовки",
                            Price = 21000.0,
                            Total = 31.0
                        },
                        new
                        {
                            Id = 99890,
                            Cluster = 0,
                            Name = "Чайник",
                            Price = 49000.0,
                            Total = 58.0
                        },
                        new
                        {
                            Id = 99889,
                            Cluster = 0,
                            Name = "Стол",
                            Price = 54000.0,
                            Total = 18.0
                        },
                        new
                        {
                            Id = 99888,
                            Cluster = 0,
                            Name = "Кресло",
                            Price = 23000.0,
                            Total = 28.0
                        },
                        new
                        {
                            Id = 99887,
                            Cluster = 0,
                            Name = "Футболка",
                            Price = 52000.0,
                            Total = 12.0
                        },
                        new
                        {
                            Id = 99886,
                            Cluster = 0,
                            Name = "Джинсы",
                            Price = 16000.0,
                            Total = 1.0
                        },
                        new
                        {
                            Id = 99885,
                            Cluster = 0,
                            Name = "Рюкзак",
                            Price = 41000.0,
                            Total = 37.0
                        },
                        new
                        {
                            Id = 99884,
                            Cluster = 0,
                            Name = "Книжная полка",
                            Price = 40000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99883,
                            Cluster = 0,
                            Name = "Ковер",
                            Price = 22000.0,
                            Total = 10.0
                        },
                        new
                        {
                            Id = 99882,
                            Cluster = 0,
                            Name = "Светильник",
                            Price = 45000.0,
                            Total = 29.0
                        },
                        new
                        {
                            Id = 99881,
                            Cluster = 0,
                            Name = "Скейтборд",
                            Price = 55000.0,
                            Total = 7.0
                        },
                        new
                        {
                            Id = 99880,
                            Cluster = 0,
                            Name = "Мышь",
                            Price = 55000.0,
                            Total = 2.0
                        },
                        new
                        {
                            Id = 99879,
                            Cluster = 0,
                            Name = "Клавиатура",
                            Price = 28000.0,
                            Total = 9.0
                        },
                        new
                        {
                            Id = 99878,
                            Cluster = 0,
                            Name = "Платье",
                            Price = 28000.0,
                            Total = 52.0
                        },
                        new
                        {
                            Id = 99877,
                            Cluster = 0,
                            Name = "Пижама",
                            Price = 23000.0,
                            Total = 1.0
                        },
                        new
                        {
                            Id = 99876,
                            Cluster = 0,
                            Name = "Пазл",
                            Price = 59000.0,
                            Total = 38.0
                        },
                        new
                        {
                            Id = 99875,
                            Cluster = 0,
                            Name = "Велосипед",
                            Price = 15000.0,
                            Total = 23.0
                        },
                        new
                        {
                            Id = 99874,
                            Cluster = 0,
                            Name = "Шапка",
                            Price = 20000.0,
                            Total = 17.0
                        },
                        new
                        {
                            Id = 99873,
                            Cluster = 0,
                            Name = "Подушка",
                            Price = 28000.0,
                            Total = 28.0
                        },
                        new
                        {
                            Id = 99872,
                            Cluster = 0,
                            Name = "Зонтик",
                            Price = 35000.0,
                            Total = 27.0
                        },
                        new
                        {
                            Id = 99871,
                            Cluster = 0,
                            Name = "Печка",
                            Price = 55000.0,
                            Total = 24.0
                        },
                        new
                        {
                            Id = 99870,
                            Cluster = 0,
                            Name = "Коврик для йоги",
                            Price = 35000.0,
                            Total = 52.0
                        },
                        new
                        {
                            Id = 99869,
                            Cluster = 0,
                            Name = "Сковорода",
                            Price = 51000.0,
                            Total = 40.0
                        },
                        new
                        {
                            Id = 99868,
                            Cluster = 0,
                            Name = "Кружка",
                            Price = 24000.0,
                            Total = 5.0
                        },
                        new
                        {
                            Id = 99867,
                            Cluster = 0,
                            Name = "Браслет",
                            Price = 30000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99866,
                            Cluster = 0,
                            Name = "Сумка",
                            Price = 15000.0,
                            Total = 31.0
                        },
                        new
                        {
                            Id = 99865,
                            Cluster = 0,
                            Name = "Очки",
                            Price = 43000.0,
                            Total = 27.0
                        },
                        new
                        {
                            Id = 99864,
                            Cluster = 0,
                            Name = "Подушка",
                            Price = 45000.0,
                            Total = 12.0
                        },
                        new
                        {
                            Id = 99863,
                            Cluster = 0,
                            Name = "Мяч",
                            Price = 20000.0,
                            Total = 21.0
                        },
                        new
                        {
                            Id = 99862,
                            Cluster = 0,
                            Name = "Подставка для ноутбука",
                            Price = 62000.0,
                            Total = 32.0
                        },
                        new
                        {
                            Id = 99861,
                            Cluster = 0,
                            Name = "Зеркало",
                            Price = 16000.0,
                            Total = 31.0
                        },
                        new
                        {
                            Id = 99860,
                            Cluster = 0,
                            Name = "Косметичка",
                            Price = 40000.0,
                            Total = 43.0
                        },
                        new
                        {
                            Id = 99859,
                            Cluster = 0,
                            Name = "Сапоги",
                            Price = 54000.0,
                            Total = 16.0
                        },
                        new
                        {
                            Id = 99858,
                            Cluster = 0,
                            Name = "Пианино",
                            Price = 22000.0,
                            Total = 28.0
                        },
                        new
                        {
                            Id = 99857,
                            Cluster = 0,
                            Name = "Спальный мешок",
                            Price = 25000.0,
                            Total = 48.0
                        },
                        new
                        {
                            Id = 99856,
                            Cluster = 0,
                            Name = "Ветровка",
                            Price = 56000.0,
                            Total = 39.0
                        },
                        new
                        {
                            Id = 99855,
                            Cluster = 0,
                            Name = "Пылесос",
                            Price = 49000.0,
                            Total = 2.0
                        },
                        new
                        {
                            Id = 99854,
                            Cluster = 0,
                            Name = "Термос",
                            Price = 20000.0,
                            Total = 29.0
                        },
                        new
                        {
                            Id = 99853,
                            Cluster = 0,
                            Name = "Рамка для фото",
                            Price = 21000.0,
                            Total = 21.0
                        },
                        new
                        {
                            Id = 99852,
                            Cluster = 0,
                            Name = "Пыльца",
                            Price = 42000.0,
                            Total = 5.0
                        },
                        new
                        {
                            Id = 99851,
                            Cluster = 0,
                            Name = "Косилка",
                            Price = 44000.0,
                            Total = 7.0
                        },
                        new
                        {
                            Id = 99850,
                            Cluster = 0,
                            Name = "Шоколад",
                            Price = 44000.0,
                            Total = 12.0
                        },
                        new
                        {
                            Id = 99849,
                            Cluster = 0,
                            Name = "Часы",
                            Price = 33000.0,
                            Total = 31.0
                        },
                        new
                        {
                            Id = 99848,
                            Cluster = 0,
                            Name = "Сумка для ноутбука",
                            Price = 51000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99847,
                            Cluster = 0,
                            Name = "Скатерть",
                            Price = 42000.0,
                            Total = 26.0
                        },
                        new
                        {
                            Id = 99846,
                            Cluster = 0,
                            Name = "Халат",
                            Price = 55000.0,
                            Total = 44.0
                        },
                        new
                        {
                            Id = 99845,
                            Cluster = 0,
                            Name = "Майка",
                            Price = 18000.0,
                            Total = 10.0
                        },
                        new
                        {
                            Id = 99844,
                            Cluster = 0,
                            Name = "Туфли",
                            Price = 20000.0,
                            Total = 12.0
                        },
                        new
                        {
                            Id = 99843,
                            Cluster = 0,
                            Name = "Фляга",
                            Price = 31000.0,
                            Total = 21.0
                        },
                        new
                        {
                            Id = 99842,
                            Cluster = 0,
                            Name = "Гитара",
                            Price = 26000.0,
                            Total = 29.0
                        },
                        new
                        {
                            Id = 99841,
                            Cluster = 0,
                            Name = "Зонт",
                            Price = 17000.0,
                            Total = 6.0
                        },
                        new
                        {
                            Id = 99840,
                            Cluster = 0,
                            Name = "Паззл",
                            Price = 29000.0,
                            Total = 22.0
                        },
                        new
                        {
                            Id = 99839,
                            Cluster = 0,
                            Name = "Телефон",
                            Price = 33000.0,
                            Total = 10.0
                        },
                        new
                        {
                            Id = 99838,
                            Cluster = 0,
                            Name = "Бейсболка",
                            Price = 42000.0,
                            Total = 15.0
                        },
                        new
                        {
                            Id = 99837,
                            Cluster = 0,
                            Name = "Мыло",
                            Price = 43000.0,
                            Total = 45.0
                        },
                        new
                        {
                            Id = 99836,
                            Cluster = 0,
                            Name = "Зубная щетка",
                            Price = 15000.0,
                            Total = 29.0
                        },
                        new
                        {
                            Id = 99835,
                            Cluster = 0,
                            Name = "Детская книга",
                            Price = 35000.0,
                            Total = 47.0
                        },
                        new
                        {
                            Id = 99834,
                            Cluster = 0,
                            Name = "Спортивные штаны",
                            Price = 55000.0,
                            Total = 1.0
                        },
                        new
                        {
                            Id = 99833,
                            Cluster = 0,
                            Name = "Журнал",
                            Price = 62000.0,
                            Total = 35.0
                        },
                        new
                        {
                            Id = 99832,
                            Cluster = 0,
                            Name = "Кольцо",
                            Price = 53000.0,
                            Total = 12.0
                        },
                        new
                        {
                            Id = 99831,
                            Cluster = 0,
                            Name = "Печь",
                            Price = 46000.0,
                            Total = 13.0
                        },
                        new
                        {
                            Id = 99830,
                            Cluster = 0,
                            Name = "Столешница",
                            Price = 23000.0,
                            Total = 16.0
                        },
                        new
                        {
                            Id = 99829,
                            Cluster = 0,
                            Name = "Вино",
                            Price = 16000.0,
                            Total = 19.0
                        },
                        new
                        {
                            Id = 99828,
                            Cluster = 0,
                            Name = "Компьютерная мышь",
                            Price = 23000.0,
                            Total = 8.0
                        },
                        new
                        {
                            Id = 99827,
                            Cluster = 0,
                            Name = "Костюм",
                            Price = 46000.0,
                            Total = 5.0
                        },
                        new
                        {
                            Id = 99826,
                            Cluster = 0,
                            Name = "Фонарик",
                            Price = 34000.0,
                            Total = 15.0
                        },
                        new
                        {
                            Id = 99825,
                            Cluster = 0,
                            Name = "Пальто",
                            Price = 57000.0,
                            Total = 23.0
                        },
                        new
                        {
                            Id = 99824,
                            Cluster = 0,
                            Name = "Футбольный мяч",
                            Price = 38000.0,
                            Total = 47.0
                        },
                        new
                        {
                            Id = 99823,
                            Cluster = 0,
                            Name = "Кастрюля",
                            Price = 18000.0,
                            Total = 14.0
                        },
                        new
                        {
                            Id = 99822,
                            Cluster = 0,
                            Name = "Письменный стол",
                            Price = 31000.0,
                            Total = 34.0
                        },
                        new
                        {
                            Id = 99821,
                            Cluster = 0,
                            Name = "Пенал",
                            Price = 40000.0,
                            Total = 59.0
                        },
                        new
                        {
                            Id = 99820,
                            Cluster = 0,
                            Name = "Печка",
                            Price = 23000.0,
                            Total = 26.0
                        },
                        new
                        {
                            Id = 99819,
                            Cluster = 0,
                            Name = "Краска для волос",
                            Price = 54000.0,
                            Total = 18.0
                        },
                        new
                        {
                            Id = 99818,
                            Cluster = 0,
                            Name = "Молоток",
                            Price = 28000.0,
                            Total = 15.0
                        },
                        new
                        {
                            Id = 99817,
                            Cluster = 0,
                            Name = "Шоколадка",
                            Price = 40000.0,
                            Total = 18.0
                        },
                        new
                        {
                            Id = 99816,
                            Cluster = 0,
                            Name = "Лампа",
                            Price = 17000.0,
                            Total = 32.0
                        },
                        new
                        {
                            Id = 99815,
                            Cluster = 0,
                            Name = "Вешалка",
                            Price = 23000.0,
                            Total = 25.0
                        },
                        new
                        {
                            Id = 99814,
                            Cluster = 0,
                            Name = "Свитер",
                            Price = 15000.0,
                            Total = 22.0
                        },
                        new
                        {
                            Id = 99813,
                            Cluster = 0,
                            Name = "Колонка",
                            Price = 60000.0,
                            Total = 10.0
                        },
                        new
                        {
                            Id = 99812,
                            Cluster = 0,
                            Name = "Ботинки",
                            Price = 30000.0,
                            Total = 45.0
                        },
                        new
                        {
                            Id = 99811,
                            Cluster = 0,
                            Name = "Серьги",
                            Price = 44000.0,
                            Total = 20.0
                        },
                        new
                        {
                            Id = 99810,
                            Cluster = 0,
                            Name = "Кольцо",
                            Price = 34000.0,
                            Total = 47.0
                        },
                        new
                        {
                            Id = 99809,
                            Cluster = 0,
                            Name = "Ножницы",
                            Price = 21000.0,
                            Total = 27.0
                        },
                        new
                        {
                            Id = 99808,
                            Cluster = 0,
                            Name = "Гель для душа",
                            Price = 17000.0,
                            Total = 3.0
                        },
                        new
                        {
                            Id = 99807,
                            Cluster = 0,
                            Name = "Радио",
                            Price = 42000.0,
                            Total = 33.0
                        },
                        new
                        {
                            Id = 99806,
                            Cluster = 0,
                            Name = "Зажигалка",
                            Price = 32000.0,
                            Total = 35.0
                        },
                        new
                        {
                            Id = 99805,
                            Cluster = 0,
                            Name = "Подставка для телефона",
                            Price = 40000.0,
                            Total = 46.0
                        },
                        new
                        {
                            Id = 99804,
                            Cluster = 0,
                            Name = "Рюкзак",
                            Price = 63000.0,
                            Total = 20.0
                        },
                        new
                        {
                            Id = 99803,
                            Cluster = 0,
                            Name = "Скатерть",
                            Price = 24000.0,
                            Total = 38.0
                        },
                        new
                        {
                            Id = 99802,
                            Cluster = 0,
                            Name = "Косметичка",
                            Price = 22000.0,
                            Total = 21.0
                        },
                        new
                        {
                            Id = 99801,
                            Cluster = 0,
                            Name = "Мягкая игрушка",
                            Price = 35000.0,
                            Total = 16.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
