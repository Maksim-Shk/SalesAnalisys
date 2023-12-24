using Accord;
using SalesAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesAnalisys;

public static class DataGenerator
{

    private static Random _random = new Random();
    private static int _entityIdCounter { get; set; } = 100000;

    public static List<Product> GenerateProducts(int count)
    {
        var products = new List<Product>();

        for (int i = 1; i <= count; i++)
        {
            var product = new Product(); // Создаем новый экземпляр Product на каждой итерации

            product.Id = _entityIdCounter--;
            product.Name = ProductNames[i - 1];

            double randomValue = _random.NextDouble();
            if (randomValue < 0.2) // 20% вероятность
            {
                product.Price = _random.Next(15, 25) * 1000;
                product.Total = _random.Next(27, 35);
            }
            else if (randomValue < 0.4) // следующие 20%
            {
                product.Price = _random.Next(20, 36) * 1000;
                product.Total = _random.Next(37, 45);
            }
            else if (randomValue < 0.6) // следующие 20%
            {
                product.Price = _random.Next(30, 46) * 1000;
                product.Total = _random.Next(47, 56);
            }
            else if (randomValue < 0.8) // следующие 20%
            {
                product.Price = _random.Next(40, 56) * 1000;
                product.Total = _random.Next(57, 66);
            }
            else // последние 20%
            {
                // Центральная крестовина: средние значения зарплаты и продолжительности
                product.Price = _random.Next(50, 66) * 1000;
                product.Total = _random.Next(67, 77);
            }

            products.Add(product);
        }

        return products;
    }



    private static string[] ProductNames =
       {
            "Книга", "Фотоаппарат", "Ноутбук", "Смартфон", "Фитнес-трекер",
            "Кофеварка", "Планшет", "Наушники", "Шарф", "Кроссовки",
            "Чайник", "Стол", "Кресло", "Футболка", "Джинсы",
            "Рюкзак", "Книжная полка", "Ковер", "Светильник", "Скейтборд",
            "Мышь", "Клавиатура", "Платье", "Пижама", "Пазл",
            "Велосипед", "Шапка", "Подушка", "Зонтик", "Печка",
            "Коврик для йоги", "Сковорода", "Кружка", "Браслет", "Сумка",
            "Очки", "Подушка", "Мяч", "Подставка для ноутбука", "Зеркало",
            "Косметичка", "Сапоги", "Пианино", "Спальный мешок", "Ветровка",
            "Пылесос", "Термос", "Рамка для фото", "Пыльца", "Косилка",
            "Шоколад", "Часы", "Сумка для ноутбука", "Скатерть", "Халат",
            "Майка", "Туфли", "Фляга", "Гитара", "Зонт",
            "Паззл", "Телефон", "Бейсболка", "Мыло", "Зубная щетка",
            "Детская книга", "Спортивные штаны", "Журнал", "Кольцо", "Печь",
            "Столешница", "Вино", "Компьютерная мышь", "Костюм", "Фонарик",
            "Пальто", "Футбольный мяч", "Кастрюля", "Письменный стол", "Пенал",
            "Печка", "Краска для волос", "Молоток", "Шоколадка", "Лампа",
            "Вешалка", "Свитер", "Колонка", "Ботинки", "Серьги",
            "Кольцо", "Ножницы", "Гель для душа", "Радио", "Зажигалка",
            "Подставка для телефона", "Рюкзак", "Скатерть", "Косметичка", "Мягкая игрушка"
        };
}
