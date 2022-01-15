using DevOcean.AcademyTask.Interfaces;

namespace DevOcean.AcademyTask
{
    public abstract class Spaceship : ISpaceship
    {
        private readonly int initialTax;

        public int YearOfPurchase { get; set; }

        public int YearOfTaxCalculation { get; set; }

        public int LightMilesTraveled { get; set; }

        public abstract decimal CalculateTravelTax();
    }
}
