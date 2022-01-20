namespace Task_2
{
    public class Ground : Transport
    {
        public int NumberOfWheels { get; set; }
        public int FuelConsumption { get; set; }

        public Ground(int numberOfWheels, int fuelConsumption, int enginePower, int maxSpeed, int weight, string brand)
            : base(enginePower, maxSpeed, weight, brand)
        {
            NumberOfWheels = numberOfWheels;
            FuelConsumption = fuelConsumption;
        }
    }
}