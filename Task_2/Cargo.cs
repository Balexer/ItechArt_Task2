using System;

namespace Task_2
{
    public class Cargo : Ground
    {
        public int capacity;
        public int numberOfWheels;
        public int fuelConsumption;
        public int enginePower;
        public int maxSpeed;
        public int weight;
        public string brand;

        public Cargo(int capacity, int numberOfWheels, int fuelConsumption, int enginePower, int maxSpeed, int weight,
            string brand)
            : base(numberOfWheels, fuelConsumption, enginePower, maxSpeed, weight, brand)
        {
            this.capacity = capacity;
            this.numberOfWheels = numberOfWheels;
            this.fuelConsumption = fuelConsumption;
            this.enginePower = enginePower;
            this.maxSpeed = maxSpeed;
            this.weight = weight;
            this.brand = brand;
        }

        public void Info()
        {
            double enginePowerKw = enginePower * 0.74;
            Console.WriteLine(
                $"Вместимость {capacity} т, Количество колес {numberOfWheels}, Расход топлива {fuelConsumption} (л/100км), Мощность двигателя {enginePower} (в лошадиных силах), Мощность двигателя в кВ {enginePowerKw}, Максимальная скорость {maxSpeed} км/ч, Вес машины {weight} кг, Марка машины {brand}");
        }

        public void CheckCapacity(int cargoWeight)
        {
            if (IsLoaded(cargoWeight))
                Console.WriteLine("Грузовик загружен");
            else
            {
                Console.WriteLine("Нужен грузовик побольше");
            }
        }

        private bool IsLoaded(int cargoWeight)
        {
            bool isLoaded;
            if (capacity >= cargoWeight)
            {
                isLoaded = true;
            }
            else
            {
                isLoaded = false;
            }

            return isLoaded;
        }
    }
}