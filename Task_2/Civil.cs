using System;

namespace Task_2
{
    public class Civil : Air
    {
        public int maxNumberOfPassengers;
        public bool business;
        public int wingspan;
        public int minRunway;
        public int enginePower;
        public int maxSpeed;
        public int weight;
        public string brand;

        public Civil(int maxNumberOfPassengers, bool business, int wingspan, int minRunway, int enginePower, int maxSpeed, int weight, string brand)
        :base(wingspan, minRunway, enginePower, maxSpeed, weight, brand)
        {
            this.maxNumberOfPassengers = maxNumberOfPassengers;
            this.business = business;
            this.wingspan = wingspan;
            this.minRunway = minRunway;
            this.enginePower = enginePower;
            this.maxSpeed = maxSpeed;
            this.weight = weight;
            this.brand = brand;
        }
        
        public void Info()
        {
            double enginePowerKw = enginePower * 0.74;
            Console.WriteLine($"Максимальное количество пассажиров {maxNumberOfPassengers}, Наличие бизнес класса {business}, Размах крыльев {wingspan} м, Минимальная длина взлётно-посадочной полосы для взлета {minRunway} м, Мощность двигателя {enginePower} (в лошадиных силах), Максимальная мощность двигателя в кВ {enginePowerKw}, Максимальная скорость {maxSpeed} км/ч, Вес самолета {weight} кг, Марка самолета {brand}");
            
        }
        
        public void CheckCapacity(int numberOfPassengers)
        {
            if (IsLoaded(numberOfPassengers))
                Console.WriteLine("Самолет загружен");
            else
            {
                Console.WriteLine("Нужен самолет побольше");
            }
        }

        private bool IsLoaded(int numberOfPassengers)
        {
            bool isLoaded;
            if (maxNumberOfPassengers >= numberOfPassengers)
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