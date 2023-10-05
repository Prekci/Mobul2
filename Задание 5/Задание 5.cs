using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Задание_5
{
    // Класс TemperatureSensor представляет собой датчик температуры.
    public class TemperatureSensor
    {
        // Поле с текущей температурой
        private double currentTemperature; 
        // Таймер для имитации изменения температуры каждые несколько секунд
        private readonly Timer temperatureTimer;
        // Событие TemperatureChanged, которое будет вызываться при изменении температуры
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        // Конструктор класса TemperatureSensor
        public TemperatureSensor()
        {
            // Исходная температура равна 20.0 градусов Цельсия
            currentTemperature = 20.0; 
            // Создание таймера для изменения температуры каждую 1 секунду
            temperatureTimer = new Timer(UpdateTemperature, null, 0, 1000);
        }
        // Метод UpdateTemperature вызывается таймером для имитации изменения температуры.
        private void UpdateTemperature(object state)
        {
            Random random = new Random();
            // Генерация случайного изменения температуры в пределах [-1, 1] градуса Цельсия
            double newTemperature = currentTemperature + (random.NextDouble() - 0.5) * 2.0; 
            if (newTemperature < -20.0)
            {
                newTemperature = -20.0; // Ограничение минимальной температуры
            }
            else if (newTemperature > 45.0)
            {
                newTemperature = 45.0; // Ограничение максимальной температуры
            }
            if (newTemperature != currentTemperature)
            {
                currentTemperature = newTemperature;
                // Вызов события TemperatureChanged при изменении температуры
                OnTemperatureChanged(new TemperatureChangedEventArgs(newTemperature)); 
            }
        }
        // Метод OnTemperatureChanged вызывает событие TemperatureChanged.
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Используем оператор ?. для проверки, что событие TemperatureChanged имеет методы и объекты которые будут получать уведомления
            // о событии, и только затем вызываем его
            TemperatureChanged?.Invoke(this, e);
        }

    }
    // Класс TemperatureChangedEventArgs представляет собой аргументы события TemperatureChanged
    public class TemperatureChangedEventArgs : EventArgs
    {
        public double NewTemperature { get; }
        // Конструктор класса TemperatureChangedEventArgs, принимает новое значение температуры
        public TemperatureChangedEventArgs(double newTemperature)
        {
            NewTemperature = newTemperature;
        }
    }
    // Класс Thermostat представляет собой термостат, который реагирует на изменение температуры.
    public class Thermostat
    {
        // Поле целевой температуры
        private double targetTemperature; 
        // Конструктор класса Thermostat, принимает целевую температуру
        public Thermostat(double targetTemperature)
        {
            this.targetTemperature = targetTemperature;
        }
        // Метод OnTemperatureChanged вызывается при изменении температуры и выводит информацию о текущей температуре и состоянии отопления
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Текущая температура: {e.NewTemperature:F2}°C");
            if (e.NewTemperature < targetTemperature)
            {
                Console.WriteLine("Отопление включено");
            }
            else if (e.NewTemperature > targetTemperature)
            {
                Console.WriteLine("Отопление выключено");
            }
        }
    }
    class Test
    {
        static void Main()
        {
            // Создание термостата с целевой температурой 22.0 градусов Цельсия
            Thermostat thermostat = new Thermostat(22.0); 
            // Создание датчика температуры
            TemperatureSensor temperatureSensor = new TemperatureSensor(); 
            // Подписка на событие TemperatureChanged
            temperatureSensor.TemperatureChanged += thermostat.OnTemperatureChanged; 
            Console.ReadLine();
        }
    }
}
