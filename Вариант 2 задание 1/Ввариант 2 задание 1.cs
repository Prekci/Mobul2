using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Вариант_2_задание_1
{
    public class Car
    {
        // Марка автомобиля
        public string Brand { get; set; }     
        // Модель автомобиля 
        public string Model { get; set; }      
        // Год выпуска автомобиля
        public int Year { get; set; }        
        // Цена автомобиля  
        public double Price { get; set; }      
        public Car(string brand, string model, int year, double price)
        {
            // Инициализация марки
            Brand = brand;      
            // Инициализация модели               
            Model = model; 
            // Инициализация года выпуска                    
            Year = year;      
            // Инициализация цены                 
            Price = price;                     
        }
        // Метод для расчета стоимости автомобиля с учетом скидки и налога на добавленную стоимость
        public double CalculateTotalCost(double discountPercentage, double taxRate)
        {
            // Рассчитываем стоимость после скидки
            double discountedPrice = Price - (Price * (discountPercentage / 100.0));
            // Рассчитываем налог на добавленную стоимость
            double taxAmount = discountedPrice * (taxRate / 100.0);
            // Итоговая стоимость
            double totalCost = discountedPrice + taxAmount;
            return totalCost;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите марку автомобиля:");
            string brand = Console.ReadLine();
            // Проверка ввода марки
            if (!IsValidRussianLetter(brand))
            {
                Console.WriteLine("Марка должна состоять только из букв");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Введите модель автомобиля:");
            string model = Console.ReadLine();
            // Проверка ввода модель 
            if (!IsValidRussianLettersAndNumbers(model))
            {
                Console.WriteLine("Марка должна состоять только из букв и целых цифр");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Введите год выпуска автомобиля:");
            // Чтение года выпуска и преобразование в целое число
            string yearRelease = Console.ReadLine();
            // Проверка ввода года 
            if ((!int.TryParse(yearRelease, out int year))|| (year < 0))
            {
                Console.WriteLine("Год выпуска должен быть целым неотрицательным числом");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Введите цену автомобиля:");
            // Чтение цены и преобразование в число с плавающей запятой
            string CarPrice = Console.ReadLine();
            // Проверка ввода цены 
            if ((!double.TryParse(CarPrice, out double price)) || (price < 0))
            {
                Console.WriteLine("Введено некорректное значение");
                Console.ReadLine();
                return;
            }
            // Создаем объект автомобиля с введенными значениями
            Car car = new Car(brand, model, year, price);
            Console.WriteLine("Введите процент скидки:");
            // Чтение процента скидки и преобразование в число
            string Percent_ = Console.ReadLine();  
            if ((!int.TryParse(Percent_, out int percent)) || (percent < 0))
            {
                Console.WriteLine("Процент скидки должен быть целым неотрицательным числом");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Введите процент налога на добавленную стоимость:");
            // Чтение процента налога и преобразование в число
            string taxRate_ = Console.ReadLine(); 
            if ((!int.TryParse(taxRate_, out int taxRate)) || (taxRate < 0))
            {
                Console.WriteLine("Процент налога должен быть целым неотрицательным числом");
                Console.ReadLine();
                return;
            }
            // Рассчитываем и выводим итоговую стоимость
            double totalCost = car.CalculateTotalCost(percent, taxRate);
            Console.WriteLine($"Итоговая стоимость автомобиля: ${totalCost:F2}");
            Console.ReadLine();
        }
        // Метод для проверки, что строка состоит только из русских и английских букв
        static bool IsValidRussianLetter(string brand)
        {
            return Regex.IsMatch(brand, @"^[А-Яа-я A-Za-z]+$", RegexOptions.IgnoreCase);
        }
        static bool IsValidRussianLettersAndNumbers(string model)
        {
            return Regex.IsMatch(model, @"^[А-Яа-я 0-9 A-Za-z]+$", RegexOptions.IgnoreCase);
        }
    }
}