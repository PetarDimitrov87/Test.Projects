namespace Store.Assignment
{
    public class Appliance : Product
    {
        public Appliance(string name, string brand, double price, string model, DateTime productionDate, double weight) 
            : base(name, brand, price)
        {
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }

        public string Model { get; set; }

        public DateTime ProductionDate { get; set; }

        public double Weight { get; set; }
    }
}
