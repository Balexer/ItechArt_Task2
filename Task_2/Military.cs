using System;

namespace Task_2
{
    public class Military : Air
    {
        public bool ejectionSystem;
        public int numberOfMissiles;
        public int wingspan;
        public int minRunway;
        public int enginePower;
        public int maxSpeed;
        public int weight;
        public string brand;

        public Military(bool ejectionSystem, int numberOfMissiles, int wingspan, int minRunway, int enginePower,
            int maxSpeed, int weight, string brand)
        :base(wingspan, minRunway, enginePower, maxSpeed, weight, brand)
        {
            this.ejectionSystem = ejectionSystem;
            this.numberOfMissiles = numberOfMissiles;
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
            Console.WriteLine($"Система катапультирования {ejectionSystem}, Количество ракет {numberOfMissiles}, Размах крыльев {wingspan} м, Минимальная длина взлётно-посадочной полосы для взлета {minRunway} м, Мощность двигателя {enginePower} (в лошадиных силах), Мощность двигателя в кВ {enginePowerKw}, Максимальная скорость {maxSpeed} км/ч, Вес самолета {weight} кг, Марка самолета {brand}");
            
        }

        public void Shot()
        {
            if (numberOfMissiles > 0)
            {
                Console.WriteLine("Ракета пошла!");
                numberOfMissiles--;
            }
            else
            {
                Console.WriteLine("Боеприпасы отсутствуют");
            }   
        }
        
        public void Ejection()
        {
            if (ejectionSystem)
            {
                Console.WriteLine("Катапультирование прошло успешно");
                ejectionSystem = false;
            }
            else
            {
                Console.WriteLine("У вас нет такой системы, либо кто-то уже ее использовал до вас");
            }
        }
    }
}