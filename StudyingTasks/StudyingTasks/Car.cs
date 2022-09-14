
namespace StudyingTasks
{
    public class Car
    {
        private string Brand;
        private string Model;
        private int Count;
        private double Price;

        public Car(string brand, string model, int count, double price)
        {
            SetBrand(brand);
            SetModel(model);
            SetCount(count);
            SetPrice(price);

        }
        public string GetModel() => this.Model;
        public void SetModel(string model) => this.Model = model;

        public string GetBrand() => this.Brand;

        public void SetBrand(string brand) => this.Brand = brand;

        public int GetCount() => this.Count;

        public void SetCount(int count) => this.Count = count;

        public double GetPrice() => this.Price;

        public void SetPrice(double price) => this.Price = price;
    }
}
