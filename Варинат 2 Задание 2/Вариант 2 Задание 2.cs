using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Варинат_2_Задание_2
{
    // Определение структуры Student
    struct Student
    {
        // Поля имя, группа, балл
        public string Name;
        public string Group;
        public int[] Grades;
        // Метод для вычисления среднего балла
        public double CalculateAverageGrade()
        {
            return Grades.Average();
        }
    }
    class Test
    {
        static void Main()
        {
            // Создаем массив из десяти студентов
            Student[] students = new Student[10]
            {
            new Student { Name = "Иванов И.И.", Group = "Группа 1", Grades = new int[] { 4, 5, 5, 4, 3 } },
            new Student { Name = "Петров П.П.", Group = "Группа 2", Grades = new int[] { 5, 5, 5, 5, 5 } },
            new Student { Name = "Сидоров С.С.", Group = "Группа 1", Grades = new int[] { 3, 3, 3, 3, 4 } },
            new Student { Name = "Александров А.А.", Group = "Группа 2", Grades = new int[] { 4, 4, 4, 4, 4 } },
            new Student { Name = "Козлов К.К.", Group = "Группа 1", Grades = new int[] { 5, 4, 5, 5, 4 } },
            new Student { Name = "Михайлов М.М.", Group = "Группа 2", Grades = new int[] { 3, 2, 3, 2, 2 } },
            new Student { Name = "Николаев Н.Н.", Group = "Группа 1", Grades = new int[] { 4, 5, 4, 3, 5 } },
            new Student { Name = "Дмитриев Д.Д.", Group = "Группа 2", Grades = new int[] { 4, 5, 4, 4, 5 } },
            new Student { Name = "Егоров Е.Е.", Group = "Группа 1", Grades = new int[] { 5, 5, 5, 5, 5 } },
            new Student { Name = "Сергеев С.С.", Group = "Группа 2", Grades = new int[] { 3, 4, 3, 4, 2 } }
            };
            // Сортируем студентов по возрастанию среднего балла
            Array.Sort(students, (x, y) => x.CalculateAverageGrade().CompareTo(y.CalculateAverageGrade()));
            // Выводим фамилии и номера групп студентов, имеющих только оценки 4 или 5
            Console.WriteLine("Студенты с оценками только 4 или 5:");
            foreach (var student in students)
            {
                if (student.Grades.All(grade => grade == 4 || grade == 5))
                {
                    Console.WriteLine($"{student.Name}, {student.Group}");
                }
            }
            Console.ReadLine();
        }
    }
}