using System;

Random rnd = new Random();
TemperatureSensor sensor = new TemperatureSensor();
Thermostat thermostat = new Thermostat(sensor);
while (true)
{
    sensor.ChangeTemperature(rnd.Next(-50, 50));
    Thread.Sleep(1100);
}

public delegate void TemperatureChangeHandler(int newTemperature);

public class TemperatureSensor
{
    private int currentvalue;
    public event TemperatureChangeHandler TemperatureChanged;

    public void ChangeTemperature(int value)
    {
        if (this.currentvalue == value)
        {
            Console.WriteLine("Температура не поменялась");
        }
        else
        {
            currentvalue = value;
            Console.WriteLine($"Температура изменилась, новая температура: {value}");

            // Проверка на наличие подписчиков и вызов события
            TemperatureChanged?.Invoke(value);
        }
    }
}

public class Thermostat
{
    public Thermostat(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += OnTemperatureChanged;
    }

    // Реакция на изменение температуры
    private void OnTemperatureChanged(int newTemperature)
    {
        if (newTemperature > 25)
        {
            Console.WriteLine("Температура высокая, выключаю отопление.");
        }
        else if (newTemperature < 18)
        {
            Console.WriteLine("Температура низкая, включаю отопление.");
        }
        else
        {
            Console.WriteLine("Температура в норме, ничего не делаю.");
        }
    }
}
