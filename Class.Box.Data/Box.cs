using System;

namespace Class.Box.Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                IsZeroOrNegative(value, nameof(Length));

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                IsZeroOrNegative(value, nameof(Width));

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                IsZeroOrNegative(value, nameof(Height));

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * (Length * Width) + 2 * (Length * Height) + 2 * (Width * Height);
        }

        public double LateralSurfaceArea()
        {
            return 2 * (Length * Height) + 2 * (Width * Height);
        }

        public double Volume()
        {
            return Length * Width * Height;
        }

        private void IsZeroOrNegative(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} cannot be zero or negative.");
            }
        }
    }
}
