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
                            Name = "Книга",
                            Price = 34000.0,
                            Total = 48.0
                        },
                        new
                        {
                            Id = 99899,
                            Name = "Фотоаппарат",
                            Price = 37000.0,
                            Total = 54.0
                        },
                        new
                        {
                            Id = 99898,
                            Name = "Ноутбук",
                            Price = 45000.0,
                            Total = 57.0
                        },
                        new
                        {
                            Id = 99897,
                            Name = "Смартфон",
                            Price = 54000.0,
                            Total = 58.0
                        },
                        new
                        {
                            Id = 99896,
                            Name = "Фитнес-трекер",
                            Price = 61000.0,
                            Total = 70.0
                        },
                        new
                        {
                            Id = 99895,
                            Name = "Кофеварка",
                            Price = 19000.0,
                            Total = 34.0
                        },
                        new
                        {
                            Id = 99894,
                            Name = "Планшет",
                            Price = 43000.0,
                            Total = 54.0
                        },
                        new
                        {
                            Id = 99893,
                            Name = "Наушники",
                            Price = 21000.0,
                            Total = 37.0
                        },
                        new
                        {
                            Id = 99892,
                            Name = "Шарф",
                            Price = 60000.0,
                            Total = 68.0
                        },
                        new
                        {
                            Id = 99891,
                            Name = "Кроссовки",
                            Price = 34000.0,
                            Total = 48.0
                        },
                        new
                        {
                            Id = 99890,
                            Name = "Чайник",
                            Price = 45000.0,
                            Total = 62.0
                        },
                        new
                        {
                            Id = 99889,
                            Name = "Стол",
                            Price = 61000.0,
                            Total = 67.0
                        },
                        new
                        {
                            Id = 99888,
                            Name = "Кресло",
                            Price = 20000.0,
                            Total = 37.0
                        },
                        new
                        {
                            Id = 99887,
                            Name = "Футболка",
                            Price = 32000.0,
                            Total = 40.0
                        },
                        new
                        {
                            Id = 99886,
                            Name = "Джинсы",
                            Price = 16000.0,
                            Total = 28.0
                        },
                        new
                        {
                            Id = 99885,
                            Name = "Рюкзак",
                            Price = 54000.0,
                            Total = 67.0
                        },
                        new
                        {
                            Id = 99884,
                            Name = "Книжная полка",
                            Price = 21000.0,
                            Total = 32.0
                        },
                        new
                        {
                            Id = 99883,
                            Name = "Ковер",
                            Price = 46000.0,
                            Total = 58.0
                        },
                        new
                        {
                            Id = 99882,
                            Name = "Светильник",
                            Price = 32000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99881,
                            Name = "Скейтборд",
                            Price = 16000.0,
                            Total = 33.0
                        },
                        new
                        {
                            Id = 99880,
                            Name = "Мышь",
                            Price = 54000.0,
                            Total = 63.0
                        },
                        new
                        {
                            Id = 99879,
                            Name = "Клавиатура",
                            Price = 17000.0,
                            Total = 31.0
                        },
                        new
                        {
                            Id = 99878,
                            Name = "Платье",
                            Price = 33000.0,
                            Total = 42.0
                        },
                        new
                        {
                            Id = 99877,
                            Name = "Пижама",
                            Price = 25000.0,
                            Total = 42.0
                        },
                        new
                        {
                            Id = 99876,
                            Name = "Пазл",
                            Price = 54000.0,
                            Total = 59.0
                        },
                        new
                        {
                            Id = 99875,
                            Name = "Велосипед",
                            Price = 50000.0,
                            Total = 61.0
                        },
                        new
                        {
                            Id = 99874,
                            Name = "Шапка",
                            Price = 30000.0,
                            Total = 48.0
                        },
                        new
                        {
                            Id = 99873,
                            Name = "Подушка",
                            Price = 35000.0,
                            Total = 38.0
                        },
                        new
                        {
                            Id = 99872,
                            Name = "Зонтик",
                            Price = 57000.0,
                            Total = 76.0
                        },
                        new
                        {
                            Id = 99871,
                            Name = "Печка",
                            Price = 38000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99870,
                            Name = "Коврик для йоги",
                            Price = 50000.0,
                            Total = 70.0
                        },
                        new
                        {
                            Id = 99869,
                            Name = "Сковорода",
                            Price = 45000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99868,
                            Name = "Кружка",
                            Price = 30000.0,
                            Total = 42.0
                        },
                        new
                        {
                            Id = 99867,
                            Name = "Браслет",
                            Price = 31000.0,
                            Total = 55.0
                        },
                        new
                        {
                            Id = 99866,
                            Name = "Сумка",
                            Price = 45000.0,
                            Total = 62.0
                        },
                        new
                        {
                            Id = 99865,
                            Name = "Очки",
                            Price = 18000.0,
                            Total = 29.0
                        },
                        new
                        {
                            Id = 99864,
                            Name = "Подушка",
                            Price = 34000.0,
                            Total = 43.0
                        },
                        new
                        {
                            Id = 99863,
                            Name = "Мяч",
                            Price = 23000.0,
                            Total = 34.0
                        },
                        new
                        {
                            Id = 99862,
                            Name = "Подставка для ноутбука",
                            Price = 41000.0,
                            Total = 53.0
                        },
                        new
                        {
                            Id = 99861,
                            Name = "Зеркало",
                            Price = 42000.0,
                            Total = 65.0
                        },
                        new
                        {
                            Id = 99860,
                            Name = "Косметичка",
                            Price = 50000.0,
                            Total = 60.0
                        },
                        new
                        {
                            Id = 99859,
                            Name = "Сапоги",
                            Price = 31000.0,
                            Total = 48.0
                        },
                        new
                        {
                            Id = 99858,
                            Name = "Пианино",
                            Price = 21000.0,
                            Total = 33.0
                        },
                        new
                        {
                            Id = 99857,
                            Name = "Спальный мешок",
                            Price = 23000.0,
                            Total = 42.0
                        },
                        new
                        {
                            Id = 99856,
                            Name = "Ветровка",
                            Price = 57000.0,
                            Total = 70.0
                        },
                        new
                        {
                            Id = 99855,
                            Name = "Пылесос",
                            Price = 34000.0,
                            Total = 43.0
                        },
                        new
                        {
                            Id = 99854,
                            Name = "Термос",
                            Price = 20000.0,
                            Total = 44.0
                        },
                        new
                        {
                            Id = 99853,
                            Name = "Рамка для фото",
                            Price = 41000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99852,
                            Name = "Пыльца",
                            Price = 55000.0,
                            Total = 64.0
                        },
                        new
                        {
                            Id = 99851,
                            Name = "Косилка",
                            Price = 39000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99850,
                            Name = "Шоколад",
                            Price = 35000.0,
                            Total = 54.0
                        },
                        new
                        {
                            Id = 99849,
                            Name = "Часы",
                            Price = 42000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99848,
                            Name = "Сумка для ноутбука",
                            Price = 20000.0,
                            Total = 32.0
                        },
                        new
                        {
                            Id = 99847,
                            Name = "Скатерть",
                            Price = 32000.0,
                            Total = 38.0
                        },
                        new
                        {
                            Id = 99846,
                            Name = "Халат",
                            Price = 27000.0,
                            Total = 40.0
                        },
                        new
                        {
                            Id = 99845,
                            Name = "Майка",
                            Price = 53000.0,
                            Total = 58.0
                        },
                        new
                        {
                            Id = 99844,
                            Name = "Туфли",
                            Price = 20000.0,
                            Total = 44.0
                        },
                        new
                        {
                            Id = 99843,
                            Name = "Фляга",
                            Price = 49000.0,
                            Total = 63.0
                        },
                        new
                        {
                            Id = 99842,
                            Name = "Гитара",
                            Price = 24000.0,
                            Total = 31.0
                        },
                        new
                        {
                            Id = 99841,
                            Name = "Зонт",
                            Price = 23000.0,
                            Total = 30.0
                        },
                        new
                        {
                            Id = 99840,
                            Name = "Паззл",
                            Price = 24000.0,
                            Total = 37.0
                        },
                        new
                        {
                            Id = 99839,
                            Name = "Телефон",
                            Price = 42000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99838,
                            Name = "Бейсболка",
                            Price = 15000.0,
                            Total = 33.0
                        },
                        new
                        {
                            Id = 99837,
                            Name = "Мыло",
                            Price = 23000.0,
                            Total = 30.0
                        },
                        new
                        {
                            Id = 99836,
                            Name = "Зубная щетка",
                            Price = 45000.0,
                            Total = 50.0
                        },
                        new
                        {
                            Id = 99835,
                            Name = "Детская книга",
                            Price = 42000.0,
                            Total = 65.0
                        },
                        new
                        {
                            Id = 99834,
                            Name = "Спортивные штаны",
                            Price = 50000.0,
                            Total = 63.0
                        },
                        new
                        {
                            Id = 99833,
                            Name = "Журнал",
                            Price = 23000.0,
                            Total = 28.0
                        },
                        new
                        {
                            Id = 99832,
                            Name = "Кольцо",
                            Price = 17000.0,
                            Total = 31.0
                        },
                        new
                        {
                            Id = 99831,
                            Name = "Печь",
                            Price = 22000.0,
                            Total = 40.0
                        },
                        new
                        {
                            Id = 99830,
                            Name = "Столешница",
                            Price = 24000.0,
                            Total = 39.0
                        },
                        new
                        {
                            Id = 99829,
                            Name = "Вино",
                            Price = 27000.0,
                            Total = 40.0
                        },
                        new
                        {
                            Id = 99828,
                            Name = "Компьютерная мышь",
                            Price = 57000.0,
                            Total = 71.0
                        },
                        new
                        {
                            Id = 99827,
                            Name = "Костюм",
                            Price = 16000.0,
                            Total = 30.0
                        },
                        new
                        {
                            Id = 99826,
                            Name = "Фонарик",
                            Price = 53000.0,
                            Total = 75.0
                        },
                        new
                        {
                            Id = 99825,
                            Name = "Пальто",
                            Price = 32000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99824,
                            Name = "Футбольный мяч",
                            Price = 50000.0,
                            Total = 60.0
                        },
                        new
                        {
                            Id = 99823,
                            Name = "Кастрюля",
                            Price = 24000.0,
                            Total = 27.0
                        },
                        new
                        {
                            Id = 99822,
                            Name = "Письменный стол",
                            Price = 18000.0,
                            Total = 33.0
                        },
                        new
                        {
                            Id = 99821,
                            Name = "Пенал",
                            Price = 47000.0,
                            Total = 57.0
                        },
                        new
                        {
                            Id = 99820,
                            Name = "Печка",
                            Price = 44000.0,
                            Total = 60.0
                        },
                        new
                        {
                            Id = 99819,
                            Name = "Краска для волос",
                            Price = 52000.0,
                            Total = 68.0
                        },
                        new
                        {
                            Id = 99818,
                            Name = "Молоток",
                            Price = 49000.0,
                            Total = 63.0
                        },
                        new
                        {
                            Id = 99817,
                            Name = "Шоколадка",
                            Price = 24000.0,
                            Total = 27.0
                        },
                        new
                        {
                            Id = 99816,
                            Name = "Лампа",
                            Price = 33000.0,
                            Total = 55.0
                        },
                        new
                        {
                            Id = 99815,
                            Name = "Вешалка",
                            Price = 31000.0,
                            Total = 49.0
                        },
                        new
                        {
                            Id = 99814,
                            Name = "Свитер",
                            Price = 23000.0,
                            Total = 27.0
                        },
                        new
                        {
                            Id = 99813,
                            Name = "Колонка",
                            Price = 53000.0,
                            Total = 76.0
                        },
                        new
                        {
                            Id = 99812,
                            Name = "Ботинки",
                            Price = 23000.0,
                            Total = 30.0
                        },
                        new
                        {
                            Id = 99811,
                            Name = "Серьги",
                            Price = 63000.0,
                            Total = 67.0
                        },
                        new
                        {
                            Id = 99810,
                            Name = "Кольцо",
                            Price = 62000.0,
                            Total = 71.0
                        },
                        new
                        {
                            Id = 99809,
                            Name = "Ножницы",
                            Price = 31000.0,
                            Total = 55.0
                        },
                        new
                        {
                            Id = 99808,
                            Name = "Гель для душа",
                            Price = 34000.0,
                            Total = 44.0
                        },
                        new
                        {
                            Id = 99807,
                            Name = "Радио",
                            Price = 16000.0,
                            Total = 30.0
                        },
                        new
                        {
                            Id = 99806,
                            Name = "Зажигалка",
                            Price = 36000.0,
                            Total = 55.0
                        },
                        new
                        {
                            Id = 99805,
                            Name = "Подставка для телефона",
                            Price = 64000.0,
                            Total = 70.0
                        },
                        new
                        {
                            Id = 99804,
                            Name = "Рюкзак",
                            Price = 24000.0,
                            Total = 27.0
                        },
                        new
                        {
                            Id = 99803,
                            Name = "Скатерть",
                            Price = 51000.0,
                            Total = 64.0
                        },
                        new
                        {
                            Id = 99802,
                            Name = "Косметичка",
                            Price = 30000.0,
                            Total = 41.0
                        },
                        new
                        {
                            Id = 99801,
                            Name = "Мягкая игрушка",
                            Price = 36000.0,
                            Total = 51.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
