namespace Task_2
{
    public class Transport
    {
        public int EnginePower { get; set; }
        public int MaxSpeed { get; set; }
        public int Weight { get; set; }
        public string Brand { get; set; }

        public Transport(int enginePower, int maxSpeed, int weight, string brand)
        {
            EnginePower = enginePower;
            MaxSpeed = maxSpeed;
            Weight = weight;
            Brand = brand;
        }
    }
}