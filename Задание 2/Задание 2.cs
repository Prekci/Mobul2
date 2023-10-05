using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Задание_2
{
    // Базовый класс
    class Shape
    {
        // Метод для вычисления площади фигуры
        public virtual double Area()
        {
            // Изначально площадь равна 0
            return 0.0; 
        }
        // Метод для вычисления периметра фигуры
        public virtual double Perimeter()
        {
            // Изначально периметр равен 0
            return 0.0; 
        }
    }
    // Производный класс Circle
    class Circle : Shape
    {
        // Поле класса 
        private double radius;
        // Конструктор класса Circle, принимает радиус
        public Circle(double radius)
        {
            this.radius = radius;
        }
        // Переопределение метода Area для круга
        public override double Area()
        {
            // Формула площади круга
            return Math.PI * Math.Pow(radius, 2); 
        }
        // Переопределение метода Perimeter для круга
        public override double Perimeter()
        {
            // Формула периметра круга
            return 2 * Math.PI * radius; 
        }
    }
    // Производный класс Rectangle
    class Rectangle : Shape
    {
        // Поля класса
        private double width;
        private double height;
        // Конструктор класса Rectangle, принимает ширину и высоту.
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        // Переопределение метода Area() для прямоугольника.
        public override double Area()
        {
            return width * height; // Формула площади прямоугольника.
        }
        // Переопределение метода Perimeter() для прямоугольника.
        public override double Perimeter()
        {
            return 2 * (width + height); // Формула периметра прямоугольника.
        }
    }
    class Test
    {
        static void Main()
        {
            // Вывод приглашения для ввода радиуса круга
            Console.WriteLine("Введите радиус круга: "); 
            // Чтение радиуса круга
            string circleRadius = Console.ReadLine(); 
            // Проверка введенного значения
            if (!double.TryParse(circleRadius, out double circleRadius2))
            {
                Console.WriteLine("Радиус круга должен быть числом");
                Console.ReadLine();
                return;
            }
            // Создание объекта класса Circle на основе введенного радиуса
            Circle circle = new Circle(circleRadius2); 
            // Предлогается ввести ширину прямоугольника
            Console.WriteLine("Введите ширину прямоугольника: "); 
            // Чтение ширины прямоугольника 
            string rectangleWidth = Console.ReadLine();
            // Проверка введенного значения
            if (!double.TryParse(rectangleWidth, out double rectangleWidth2))
            {
                Console.WriteLine("Ширина прямоугольника должна быть числом");
                Console.ReadLine();
                return;
            }
            // Вывод приглашения для ввода высоты прямоугольника
            Console.WriteLine("Введите высоту прямоугольника: ");
            // Чтение высоты прямоугольника с клавиатуры и преобразование в число
            string rectangleHeight = Console.ReadLine();
            // Проверка введенного значения
            if (!double.TryParse(rectangleHeight, out double rectangleHeight2))
            {
                Console.WriteLine("Высота прямоугольника должна быть числом");
                Console.ReadLine();
                return;
            }
            // Создание объекта класса Rectangle на основе введенных размеров
            Rectangle rectangle = new Rectangle(rectangleWidth2, rectangleHeight2); 
            // Вывод результатов вычислений
            // Вывод площади круга
            Console.WriteLine("Площадь круга: " + circle.Area()); 
            // Вывод периметра круга
            Console.WriteLine("Периметр круга: " + circle.Perimeter()); 
            // Вывод площади прямоугольника
            Console.WriteLine("Площадь прямоугольника: " + rectangle.Area()); 
            // Вывод периметра прямоугольника
            Console.WriteLine("Периметр прямоугольника: " + rectangle.Perimeter());
            Console.ReadLine();
        }
    }
}