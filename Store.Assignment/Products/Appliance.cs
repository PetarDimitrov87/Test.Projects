namespace Store.Assignment
{
    public class Appliance : Product
    {
        public Appliance(string name, string brand, double price, int quantity, string model, DateTime productionDate, double weight) 
            : base(name, brand, price, quantity)
        {
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }

        public string Model { get; private set; }

        public DateTime ProductionDate { get; private set; }

        public double Weight { get; private set; }

        public override double GetPriceAt(DateTime dateTime)
        {
            if (DateUtils.IsWeekend(dateTime) && Price > 999)
            {
                return 0.95 * Price;
            }

            return Price;
        }
    }
}
