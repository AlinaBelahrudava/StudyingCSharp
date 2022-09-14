namespace StudyingTasks.Commands
{
    public class AddNewCar : ICommand
    {
        private Catalogue Catalogue;
        private string Brand;
        private string Model;
        private int Count;
        private double Price;

        public AddNewCar(Catalogue catalogue, string brand, string model, int count, double price)
        {
            this.Catalogue = catalogue;
            this.Brand = brand;
            this.Model = model;
            this.Count = count;
            this.Price = price;
        }
        public void Execute()
        {
            Catalogue.AddNewCar(Brand, Model, Count, Price);
        }
    }
}
