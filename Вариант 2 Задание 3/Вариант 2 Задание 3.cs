using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вариант_2_Задание_3
{
    // Абстрактный класс "Геометрическая фигура"
    public abstract class Shape
    {
        // Абстрактный метод для вычисления площади фигуры
        public abstract double CalculateArea();
    }
    // Класс "Круг"
    public class Circle : Shape
    {
        // Радиус круга
        private double radius;
        public Circle(double radius)
        {
            // Инициализируем поле радиуса круга
            this.radius = radius;
        }
        // Реализация метода для вычисления площади круга
        public override double CalculateArea()
        {
            // Формула для вычисления площади круга
            return Math.PI * radius * radius;
        }
    }
    // Класс "Прямоугольник"
    public class Rectangle : Shape
    {
        // Ширина и высота прямоугольника
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            // Инициализация полей ширины и высоты прямоугольника
            this.width = width;
            this.height = height;
        }
        // Реализация метода для вычисления площади прямоугольника
        public override double CalculateArea()
        {
            // Формула для вычисления площади прямоугольника
            return width * height;
        }
    }
    // Класс "Треугольник"
    public class Triangle : Shape
    {
        // Длины сторон
        private double a;
        private double b;
        private double c;
        public Triangle(double a, double b, double c)
        {
            // Инициализация полей длин сторон
            this.a = a;
            this.b = b;
            this.c = c;
        }
        // Реализация метода для вычисления площади треугольника по формуле Герона
        public override double CalculateArea()
        {
            // Полупериметр треугольника
            double s = (a + b + c) / 2;
            // Формула для вычисления площади треугольника
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите фигуру: ");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Прямоугольник");
                Console.WriteLine("3. Треугольник");
                // Считываем выбор пользователя
                string choice_ = Console.ReadLine();
                // Считываем ввод пользователя и преобразовываем его в целое число
                if (!int.TryParse(choice_, out int choice))
                {
                    // Вывод сообщения об ошибке при некорректном вводе
                    Console.WriteLine("Введите корректное число");
                    // Продолжение цикла
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите радиус круга: ");
                        double radiusCircle;
                        while (!double.TryParse(Console.ReadLine(), out radiusCircle))
                        {
                            Console.WriteLine("Некорректный ввод. Повторите попытку.");
                            Console.Write("Введите радиус круга: ");
                            continue;
                        }
                        // Создаем объект класса "Круг"
                        Circle circle = new Circle(radiusCircle);
                        // Выводим площадь круга с точностью до двух знаков после запятой
                        Console.WriteLine($"Площадь круга: {circle.CalculateArea():F2}");
                        Console.Write("Нажмите Enter для продолжения...");
                        break;
                    case 2:
                        Console.Write("Введите ширину прямоугольника: ");
                        double widthRectangle;
                        while (!double.TryParse(Console.ReadLine(), out widthRectangle))
                        {
                            Console.WriteLine("Некорректный ввод. Повторите попытку.");
                            Console.Write("Введите ширину прямоугольника: ");
                        }
                        Console.Write("Введите высоту прямоугольника: ");
                        double heightRectangle;
                        while (!double.TryParse(Console.ReadLine(), out heightRectangle))
                        {
                            Console.WriteLine("Некорректный ввод. Повторите попытку.");
                            Console.Write("Введите высоту прямоугольника: ");
                        }
                        // Создаем объект класса "Прямоугольник"
                        Rectangle rectangle = new Rectangle(widthRectangle, heightRectangle);
                        // Выводим площадь прямоугольника с точностью до двух знаков после запятой
                        Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea():F2}");
                        Console.Write("Нажмите Enter для продолжения...");
                        break;
                    case 3:
                        Console.Write("Введите длину стороны a: ");
                        double sideA;
                        while (!double.TryParse(Console.ReadLine(), out sideA))
                        {
                            Console.WriteLine("Некорректный ввод. Повторите попытку.");
                            Console.Write("Введите длину стороны a: ");
                        }
                        Console.Write("Введите длину стороны b: ");
                        double sideB;
                        while (!double.TryParse(Console.ReadLine(), out sideB))
                        {
                            Console.WriteLine("Некорректный ввод. Повторите попытку.");
                            Console.Write("Введите длину стороны b: ");
                        }
                        Console.Write("Введите длину стороны c: ");
                        double sideC;
                        while (!double.TryParse(Console.ReadLine(), out sideC))
                        {
                            Console.WriteLine("Некорректный ввод. Повторите попытку.");
                            Console.Write("Введите длину стороны c: ");
                        }
                        // Создаем объект класса "Треугольник"
                        Triangle triangle = new Triangle(sideA, sideB, sideC);
                        // Выводим площадь треугольника с точностью до двух знаков после запятой
                        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea():F2}");
                        Console.Write("Нажмите Enter для продолжения...");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        Console.Write("Нажмите Enter для продолжения...");
                        break;
                } 
                Console.ReadLine();
            }
        }
    }
}