namespace StudyingTasks.Commands
{
    public class AverageCommand : ICommand
    {
        public const string Price = "price";
        private Catalogue Catalogue;
        private string[] Arguments;

        public AverageCommand(Catalogue catalogue, string[] arguments)
        {
            this.Catalogue = catalogue;
            this.Arguments = arguments;
        }
        public void Execute()
        {
            if (Arguments.Length == 2)
            {

                if (Price.Equals(Arguments[1]))
                {

                    Catalogue.GetAveragePrice();
                }
                else
                {
                    Console.WriteLine("Command hasn't been recognized: " + Arguments[1]);
                }
            }
            else if (Arguments.Length == 3)
            {
                if (Price.Equals(Arguments[1]))
                {

                    Catalogue.GetAveragePriceByBrand(Arguments[2]);
                }
                else
                {
                    Console.WriteLine("Command hasn't been recognized: " + Arguments[1]);
                }
            }
            else
            {
                Console.WriteLine("Command hasn't been recognized");
            }
        }

    }
}

