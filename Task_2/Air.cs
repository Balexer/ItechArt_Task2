namespace Task_2
{
    public class Air : Transport

    {
        public int Wingspan { get; set; }
        public int MinRunway { get; set; }

        public Air(int wingspan, int minRunway, int enginePower, int maxSpeed, int weight, string brand)
            : base(enginePower, maxSpeed, weight, brand)
        {
            Wingspan = wingspan;
            MinRunway = minRunway;
        }
    }
}