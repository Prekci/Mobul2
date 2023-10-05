using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    // Интерфейс IDrawable с методом Draw()
    public interface IDrawable
    {
        void Draw(); 
    }
    // Производный класс Circle
    public class Circle : IDrawable 
    {
        // Объявление переменной для хранения радиуса
        private double radius; 
        // Конструктор класса, принимающий радиус круга
        public Circle(double radius) 
        {
            // Инициализация поля radius значением, переданным в конструктор
            this.radius = radius; 
        }
        // Реализация метода Draw()
        public void Draw() 
        {
            // Вывод информации о рисуемом круге
            Console.WriteLine($"Рисуем круг с радиусом {radius}"); 
        }
    }
    // Производный класс Rectangle
    public class Rectangle : IDrawable
    {
        // Объявление переменных для хранения высоты и ширины
        private double width;
        private double height;
        // Конструктор класса, принимающий размеры прямоугольника
        public Rectangle(double width, double height)
        {
            // Инициализация полей width и height значением, переданным в конструктор
            this.width = width;
            this.height = height;
        }
        // Реализация метода Draw() для прямоугольника
        public void Draw()
        {
            // Вывод информации о рисуемом прямоугольнике
            Console.WriteLine($"Рисуем прямоугольник с шириной {width} и высотой {height}");
        }
    }
    // Производный класс Triangle
    public class Triangle : IDrawable
    {
        // Объявление переменных для хранения трех сторон
        private double side1;
        private double side2;
        private double side3;
        // Конструктор класса, принимающий размеры треугольника
        public Triangle(double side1, double side2, double side3)
        {
            // Инициализация полей 3-х сторон значением, переданным в конструктор
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        // Реализация метода Draw() для треугольника
        public void Draw()
        {
            // Вывод информации о рисуемом треугольнике
            Console.WriteLine($"Рисуем треугольник со сторонами {side1}, {side2} и {side3}");
        }
    }
    // Объявление класса Test
    class Test 
    {
        // Объявление метода Main
        static void Main() 
        {
            // Начало бесконечного цикла
            while (true) 
            {
                // Предлогается выбрать фигуру
                Console.WriteLine("Выберите фигуру для рисования:"); 
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Прямоугольник");
                Console.WriteLine("3. Треугольник");
                // Объявление переменной для хранения выбора пользователя
                int choice; 
                // Считываем ввод пользователя и преобразовываем его в целое число
                if (!int.TryParse(Console.ReadLine(), out choice)) 
                {
                    // Вывод сообщения об ошибке при некорректном вводе
                    Console.WriteLine("Введите корректное число"); 
                    // Продолжение цикла
                    continue; 
                }
                // Объявление переменной для хранения выбранной фигуры
                IDrawable shape = null; 
                // Начало блока switch для обработки выбора пользователя
                switch (choice) 
                {
                    case 1: // Если пользователь выбрал 1 
                        Console.WriteLine("Введите радиус круга:"); 
                        // Считывание и попытка преобразования радиуса в число
                        if (!double.TryParse(Console.ReadLine(), out double circleRadius))
                        {
                            // Вывод сообщения об ошибке при некорректном вводе
                            Console.WriteLine("Введите корректное число");
                            // Продолжение цикла
                            continue; 
                        }
                        // Создание объекта класса Circle с указанным радиусом
                        shape = new Circle(circleRadius); 
                        // Завершение обработки выбора
                        break;
                        // Если пользователь выбрал 2
                    case 2: 
                        Console.WriteLine("Введите ширину прямоугольника:");
                        // Считывание и попытка преобразования ширины в число
                        if (!double.TryParse(Console.ReadLine(), out double rectangleWidth))
                        {
                            // Вывод сообщения об ошибке при некорректном вводе
                            Console.WriteLine("Введите корректное число");
                            // Продолжение цикла
                            continue;
                        }
                        Console.WriteLine("Введите высоту прямоугольника:");
                        // Считывание и попытка преобразования высоты в число
                        if (!double.TryParse(Console.ReadLine(), out double rectangleHeight))
                        {
                            // Вывод сообщения об ошибке при некорректном вводе
                            Console.WriteLine("Введите корректное число");
                            // Продолжение цикла
                            continue;
                        }
                        // Создание объекта класса Rectangle с указанными размерами
                        shape = new Rectangle(rectangleWidth, rectangleHeight);
                        // Завершение обработки выбора
                        break;
                    // Если пользователь выбрал 3
                    case 3: 
                        Console.WriteLine("Введите сторону A треугольника:");
                        // Считывание и попытка преобразования A стороны в число
                        if (!double.TryParse(Console.ReadLine(), out double triangleSideA))
                        {
                            // Вывод сообщения об ошибке при некорректном вводе
                            Console.WriteLine("Введите корректное число");
                            // Продолжение цикла
                            continue;
                        }
                        Console.WriteLine("Введите сторону B треугольника:");
                        // Считывание и попытка преобразования B стороны в число
                        if (!double.TryParse(Console.ReadLine(), out double triangleSideB))
                        {
                            // Вывод сообщения об ошибке при некорректном вводе
                            Console.WriteLine("Введите корректное число");
                            // Продолжение цикла
                            continue;
                        }
                        Console.WriteLine("Введите сторону C треугольника:");
                        // Считывание и попытка преобразования C стороны в число
                        if (!double.TryParse(Console.ReadLine(), out double triangleSideC))
                        {
                            // Вывод сообщения об ошибке при некорректном вводе
                            Console.WriteLine("Введите корректное число");
                            // Продолжение цикла
                            continue;
                        }
                        // Создание объекта класса Rectangle с указанными размерами
                        shape = new Triangle(triangleSideA, triangleSideB, triangleSideC);
                        // Завершение обработки выбора
                        break;
                }
                // Проверка, что выбранная фигура не равна null
                if (shape != null) 
                {
                    // Вызов метода Draw() для выбранной фигуры
                    shape.Draw(); 
                }
                // Вывод пустой строки для разделения вывода
                Console.WriteLine(); 
            }
        }
    }
}