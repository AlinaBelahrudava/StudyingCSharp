namespace StudyingTasks
{
    public class Catalogue
    {
        public const string DollarFormat = "{0:0,0.00}$";
        private static readonly Catalogue Instance = new();
        private List<Car> Cars = new();

        private Catalogue()
        {

        }

        public static Catalogue GetInstance()
        {
            return Instance;
        }
        public void AddNewCar(string brand, string model, int count, double price)
        {

            this.Cars.Add(new Car(brand, model, count, price));

        }

        public int GetBrandsCount()
        {
            int count = this.Cars.GroupBy(car => car.GetBrand()).Count();
            Console.WriteLine("Brands count: " + count);
            return count;
        }

        public int GetCarsCount()
        {
            int count = 0;
            this.Cars.ForEach(car => count += car.GetCount());
            Console.WriteLine("Cars count: " + count);
            return count;
        }

        public double GetAveragePrice()
        {
            double summ = 0;
            this.Cars.ForEach(car => summ += car.GetPrice());
            double averagePrice = summ / Cars.Count();
            Console.WriteLine("Average price: " + string.Format(DollarFormat, averagePrice));
            return averagePrice;
        }

        public double GetAveragePriceByBrand(string brand)
        {
            double summ = 0;
            int i = 0;
            foreach (Car car in this.Cars.GroupBy(car => car.GetBrand()).Where(g => brand.Equals(g.Key)).SelectMany(g => g))
            {
                summ += car.GetPrice();
                i++;
            }
            double averagePrice = -1;
            if (i != 0)
            {
                averagePrice = summ / i;
                Console.WriteLine(string.Format("Average price for {0}: ", brand) + String.Format(DollarFormat, averagePrice));
            }
            else
            {
                Console.WriteLine(String.Format("Brand '{0}' is not found", brand));
            }
            return averagePrice;
        }
    }
}
