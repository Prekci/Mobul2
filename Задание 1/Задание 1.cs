using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Задание_1
{
    class Person
    {
        // Инициализация полей
        // Поле имя
        public string Name { get; set; }
        // Поле возраст
        public int Age { get; set; }
        // Поле адрес
        public string Address { get; set; }
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }
    class Test
    {
        static void Main()
        {
            // Вводим данные для первой персоны
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            // Проверка ввода имени (должны быть только русские буквы)
            if (!IsValidRussianName(name))
            {
                Console.WriteLine("Имя должно состоять только из русских букв");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Введите возраст:");
            string ageInput = Console.ReadLine();
            // Проверка ввода возраста (должны быть только цифры)
            if (!int.TryParse(ageInput, out int age))
            {
                Console.WriteLine("Возраст должен быть целым числом");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Введите адрес:");
            string address = Console.ReadLine();
            // Проверка ввода имени (должны быть только русские буквы и цифр)
            if (!IsValidAddress(address))
            { 
                Console.WriteLine("Адрес должно состоять из русских букв");
                Console.ReadLine();
                return;
            }
            Person person = new Person(name, age, address);
            Console.WriteLine("\nИнформация:");
            Console.WriteLine($"Имя: {person.Name}");
            Console.WriteLine($"Возраст: {person.Age}");
            Console.WriteLine($"Адрес: {person.Address}");
            Console.ReadLine();
        }
        // Метод для проверки, что строка состоит только из русских букв
        static bool IsValidRussianName(string name)
        {
            return Regex.IsMatch(name, @"^[А-Яа-я]+$", RegexOptions.IgnoreCase);
        }
        // Метод для проверки, что строка состоит только из русских букв и цифр
        static bool IsValidAddress(string adress)
        {
            return Regex.IsMatch(adress, @"^[А-Яа-я 0-9]+$", RegexOptions.IgnoreCase);
        }
    }
}