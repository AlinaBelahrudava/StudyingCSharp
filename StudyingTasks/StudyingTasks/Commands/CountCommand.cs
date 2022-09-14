namespace StudyingTasks.Commands
{
    public class CountCommand : ICommand
    {
        public const string Type = "type";
        public const string All = "all";
        private Catalogue Catalogue;
        private string Argument;

        public CountCommand(Catalogue catalogue, string argument)
        {
            this.Catalogue = catalogue;
            this.Argument = argument;
        }
        public void Execute()
        {
            if (Type.Equals(Argument))
            {
                Catalogue.GetBrandsCount();
            }
            else if (All.Equals(Argument))
            {
                Catalogue.GetCarsCount();
            }
            else
            {
                Console.WriteLine(String.Format("Unsupported argument '{0}'", Argument));
            }
        }
    }
}
