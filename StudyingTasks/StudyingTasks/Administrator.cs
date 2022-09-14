using StudyingTasks.Commands;

namespace StudyingTasks
{
    public class Administrator
    {

        private ICommand Command;

        public void SetCommand(ICommand command)
        {
            this.Command = command;
        }

        public void Do()
        {
            this.Command.Execute();
        }
    }
}
