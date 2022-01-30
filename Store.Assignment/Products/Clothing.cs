namespace Store.Assignment
{
    public class Clothing : Product
    {
        public Clothing(string name, string brand, double price, Size size, string color) : base(name, brand, price)
        {
            this.Size = size;
            this.Color = color;
        }

        public Size Size { get; set; }

        public string Color { get; set; }
    }
}
