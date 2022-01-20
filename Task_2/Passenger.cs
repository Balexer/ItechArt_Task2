using System;

namespace Task_2
{
    public class Passenger : Ground
    {
        public string bodyType;
        public int numberOfPassengers;
        public int numberOfWheels;
        public int fuelConsumption;
        public int enginePower;
        public int maxSpeed;
        public int weight;
        public string brand;

        public Passenger(string bodyType, int numberOfPassengers, int numberOfWheels, int fuelConsumption, int enginePower, int maxSpeed, int weight, string brand)
        :base(numberOfWheels, fuelConsumption, enginePower, maxSpeed, weight, brand)
        {
            this.bodyType = bodyType;
            this.numberOfPassengers = numberOfPassengers;
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
            Console.WriteLine($"Тип кузова {bodyType}, Вместимость пассажиров {numberOfPassengers}, Количество колес {numberOfWheels}, Расход топлива на {fuelConsumption} л/100км, Мощность двигателя {enginePower} (в лошадиных силах), Мощность двигателя в кВ{enginePowerKw}, Максимальная скорость {maxSpeed} км/ч, Вес машины {weight} кг, Марка машины {brand}");
            
        }

        public void Consumption(int time)
        {
            Console.WriteLine($"За время {time} часов, автомобиль {brand} двигаясь с максимальной скоростью {maxSpeed} км/ч проедет {FindDistance(time)} км и израсходует {CalculateConsumption(time)} литров топлива");
        }
        
        private int FindDistance(int time)
        {
            int distance = maxSpeed * time;
            return distance;
        }

        private int CalculateConsumption(int time)
        {
            int consumption = FindDistance(time) / fuelConsumption;

            return consumption;
        }
    }
}