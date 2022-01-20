using System;
using System.Xml;

namespace Task_1
{
    public class Computer
    {
        public string cpu;
        public string ram;
        public string hdd;
        public int resource;
        public byte status;

        public Computer(string cpu, string ram, string hdd, int resource)
        {
            this.cpu = cpu;
            this.ram = ram;
            this.hdd = hdd;
            this.resource = resource;
        }

        public void Info()
        {
            Console.WriteLine(
                $"Процессор: {cpu}, Оперативка: {ram}, Жесткий диск: {hdd}, Ресурс работы: {resource} циклов");
        }

        public void TurningOn()
        {
            if (status == 0)
            {
                Console.WriteLine("Попробуем включить компьютер 1 или 0?");

                for (; PressPowerButton() == 0;)
                {
                    Console.WriteLine("Еще разок!");
                }

                Console.WriteLine("У вас получилось запустить компьютер!");
            }
            else
            {
                Console.WriteLine("Компьютер уже включен");
            }
        }

        public void TurningOff()
        {
            if (status == 0)
                Console.WriteLine("Компуктер не включен");

            else
            {
                Console.WriteLine("Попробуем выключить компьютер 1 или 0?");
                for (; PressPowerButton() == 1;)
                {
                    Console.WriteLine("Еще разок!");
                }

                Console.WriteLine("У вас получилось выключить компьютер!");
                resource--;
            }
        }

        private int PressPowerButton()
        {
            int isOn = 0;

            if (resource > 0)
            {
                isOn = TryToPressPowerButton();
            }
            else
            {
                Console.WriteLine("Ваш компьютер сгорел");
                Environment.Exit(0);
            }

            return isOn;
        }

        private int TryToPressPowerButton()
        {
            int programChoice;
            int isOn = 0;
            int userChoiсe = Convert.ToInt16(Console.ReadLine());

            programChoice = ProgramChoice();
            if (userChoiсe == programChoice)
            {
                isOn = 1;
                status = 1;
            }
            else
            {
                status = 0;
            }

            return isOn;
        }

        private int ProgramChoice()
        {
            Random rnd = new Random();
            int programChoice = rnd.Next(0, 2);
            return programChoice;
        }
    }
}