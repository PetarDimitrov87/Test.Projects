using System.Drawing;

namespace Store.Assignment
{
    public class Clothing : Product
    {
        public Clothing(string name, string brand, double price, double quantity, Size size, Color color) 
            : base(name, brand, price, quantity)
        {
            this.Size = size;
            this.Color = color;
        }

        public Size Size { get; private set; }

        public Color Color { get; private set; }

        public override double GetPriceOn(DateTime dateTime)
        {
            if (!DateUtils.IsWeekend(dateTime))
            {
                return 0.9 * Price;
            }

            return Price;
        }
    }
}
