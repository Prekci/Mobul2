using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Задание_3
{
    // Класс автор
    class Author
    {
        // Объявление свойства Name для хранения имени автора
        public string Name { get; set; } 
        // Объявление свойства BirthdayYear для хранения года рождения автора
        public int BirthdayYear { get; set; } 
        // Объявление конструктора класса Author
        public Author(string name, int birthYear) 
        {
            // Инициализация свойства Name переданным именем
            Name = name; 
            // Инициализация свойства BirthdayYear переданным годом рождения
            BirthdayYear = birthYear; 
        }
    }
    // Класса книга
    class Book 
    {
        // Объявление свойства Title для хранения названия книги
        public string Title { get; set; } 
        // Объявление свойства ReleaseYear для хранения года выпуска книги
        public int ReleaseYear { get; set; } 
        // Объявление свойства Author для хранения информации об авторе книги
        public Author Author { get; set; } 
        // Объявление конструктора класса Book
        public Book(string title, int release, Author author) 
        {
            // Инициализация свойства Title переданным названием
            Title = title; 
            // Инициализация свойства ReleaseYear переданным годом выпуска
            ReleaseYear = release; 
            // Инициализация свойства Author переданным объектом Author (автором книги)
            Author = author; 
        }
    }
}
// Класса тест
class Test 
{
    // Объявление метода Main
    static void Main() 
    {
        // Ввод информации о первом авторе
        // Предлогается ввести имя первого автора
        Console.WriteLine("Введите имя первого автора: "); 
        // Считывание введенного значения и сохранение в переменной authorName1
        string authorName1 = Console.ReadLine(); 
        // Проверка, что имя автора состоит только из русских букв
        if (!IsValidRussianName(authorName1)) 
        {
            // Если это не так то
            // Вывод сообщения об ошибке
            Console.WriteLine("Имя должно состоять только из русских букв"); 
            Console.ReadLine(); 
            return; // Завершение выполнения программы
        }
        // Предлогается ввести год рождения первого автора
        Console.WriteLine("Введите год рождения первого автора: "); 
        // Считывание введенного значения и сохранение в переменной authorBirth1
        string authorBirth1 = Console.ReadLine();
        // Попытка преобразовать введенную строку в целое число
        if (!int.TryParse(authorBirth1, out int authorBirthYear1)) 
        {
            // Если это не так то
            // Вывод сообщения об ошибке
            Console.WriteLine("Год рождения должен быть целым числом"); 
            Console.ReadLine(); 
            return; // Завершение выполнения программы
        }
        // Предлогается ввести названия первой книги
        Console.WriteLine("Введите название первой книги: "); 
        // Считывание введенного значения и сохранение в переменной bookTitle1
        string bookTitle1 = Console.ReadLine(); 
        // Проверка, что название книги состоит только из русских букв
        if (!IsValidBookName(bookTitle1)) 
        {
            // Если это не так то
            // Вывод сообщения об ошибке
            Console.WriteLine("Название должно состоять только из русских букв"); 
            Console.ReadLine(); 
            return; // Завершение выполнения программы
        }
        // Предлогается ввести год выпуска первой книги
        Console.WriteLine("Введите год выпуска первой книги: "); 
        // Считывание введенного значения и сохранение в переменной bookRelease1
        string bookRelease1 = Console.ReadLine(); 
        // Попытка преобразовать введенную строку в целое число
        if (!int.TryParse(bookRelease1, out int bookReleaseYear1)) 
        {
            // Если это не так то
            // Вывод сообщения об ошибке
            Console.WriteLine("Год выпуска должен быть целым числом"); 
            Console.ReadLine(); 
            return; // Завершение выполнения программы
        }
        // Предлогается ввести имя второго автора
        Console.WriteLine("Введите имя второго автора: "); 
        // Считывание введенного значения и сохранение в переменной authorName2
        string authorName2 = Console.ReadLine(); 
        // Проверка, что имя автора состоит только из русских букв
        if (!IsValidRussianName(authorName2)) 
        {
            // Если это не так то
            // Вывод сообщения об ошибке
            Console.WriteLine("Имя должно состоять только из русских букв"); 
            Console.ReadLine(); 
            return; // Завершение выполнения программы
        }
        // Предлогается ввести год рождения второго автора
        Console.WriteLine("Введите год рождения второго автора: "); 
        // Считывание введенного значения и сохранение в переменной authorBirth2
        string authorBirth2 = Console.ReadLine(); 
        // Попытка преобразовать введенную строку в целое число
        if (!int.TryParse(authorBirth2, out int authorBirthYear2)) 
        {
            // Если это не так то
            // Вывод сообщения об ошибке
            Console.WriteLine("Год рождения должен быть целым числом"); 
            Console.ReadLine(); 
            return; // Завершение выполнения программы
        }
        // Вывод на экран приглашения для ввода названия второй книги
        Console.WriteLine("Введите название второй книги: "); 
        // Считывание введенного значения и сохранение в переменной bookTitle2
        string bookTitle2 = Console.ReadLine(); 
        // Проверка, что название второй книги состоит только из русских букв
        if (!IsValidBookName(bookTitle2)) 
        {
            // Если это не так то
            // Вывод сообщения об ошибке
            Console.WriteLine("Название должно состоять только из русских букв"); 
            Console.ReadLine(); 
            return; // Завершение выполнения программы
        }
        // Вывод на экран приглашения для ввода года выпуска второй книги
        Console.WriteLine("Введите год выпуска второй книги: "); 
        // Считывание введенного значения и сохранение в переменной bookRelease2
        string bookRelease2 = Console.ReadLine(); 
        // Попытка преобразовать введенную строку в целое число 
        if (!int.TryParse(bookRelease2, out int bookReleaseYear2)) 
        {
            // Если это не так то
            // Вывод сообщения об ошибке
            Console.WriteLine("Год выпуска должен быть целым числом");
            Console.ReadLine();
            return; // Завершение выполнения программы
        }
        // Вывод информации о книгах и их авторах
        Console.WriteLine("Информация о первом авторе:");
        Console.WriteLine("Автор: " + authorName1);
        Console.WriteLine("Год рождения автора: " + authorBirthYear1);
        Console.WriteLine("Информация о первой книге:");
        Console.WriteLine("Книга: " + bookTitle1);
        Console.WriteLine("Год выпуска: " + bookReleaseYear1);
        Console.WriteLine("Автор книги: " + authorName1);
        Console.WriteLine("Информация о втором авторе:");
        Console.WriteLine("Автор: " + authorName2);
        Console.WriteLine("Год рождения автора: " + authorBirthYear2);
        Console.WriteLine("Информация о второй книге:");
        Console.WriteLine("Книга: " + bookTitle2);
        Console.WriteLine("Год выпуска: " + bookReleaseYear2);
        Console.WriteLine("Автор книги: " + authorName2);
        Console.ReadLine() ;
    }
    // Метод для проверки, что строка состоит только из русских букв
    static bool IsValidRussianName(string Name) 
    {
        // Проверка, что строка состоит только из русских букв
        return Regex.IsMatch(Name, @"^[А-Яа-я .]+$", RegexOptions.IgnoreCase); 
    }
    // Метод для проверки, что строка состоит только из русских букв и цифр
    static bool IsValidBookName(string Title)
    {
        return Regex.IsMatch(Title, @"^[А-Яа-я 0-9]+$", RegexOptions.IgnoreCase);
    }
}