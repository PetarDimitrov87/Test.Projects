using System.Drawing;

namespace Store.Assignment
{
    public class Clothing : Product
    {
        public Clothing(string name, string brand, double price, Size size, Color color) 
            : base(name, brand, price)
        {
            this.Size = size;
            this.Color = color;
        }

        public Size Size { get; private set; }

        public Color Color { get; private set; }
    }
}
