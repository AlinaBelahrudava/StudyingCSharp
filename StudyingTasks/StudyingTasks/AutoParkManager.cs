using Entity;
using StudyingTasks.Exceptions;

namespace StudyingTasks
{
    public class AutoParkManager
    {
        private List<Transport> Transport = new();

        public List<Transport> GetTransport() => this.Transport;
        public void SetTransport(List<Transport> transports) => this.Transport = new(transports);

        public AutoParkManager(List<Transport> transports)
        {
            this.Transport = new(transports);
        }

        public void AddTransport(Transport transport)
        {
            if (null == transport)
            {
                throw new AddException("Invalid data. Value null cannot ne added.");
            }
            if (Transport.Where(t => t.GetID() == transport.GetID()).GetEnumerator().MoveNext())
            {
                throw new AddException(String.Format("Invalid data. Transport with ID '{0}' already exists.", transport.GetID()));
            }
            Transport.Add(transport);
        }

        public void GetAutoByParameter(string parameter, string value)
        {
           
            //GetAutoByParameterException
        }

        public void UpdateAuto(Transport transport)
        {

            IEnumerator<Transport> enumerator = Transport.Where(t => t.GetID() == transport.GetID()).GetEnumerator();
            if (enumerator.MoveNext())
            {
                Transport.Remove(enumerator.Current);
                Transport.Add(transport);
            }
            else
            {
                throw new UpdateAutoException(String.Format("Update unsuccessful. Item with id '{0}' not found.", transport.GetID()));
            }
        }

        public void RemoveAuto(int id)
        {
            IEnumerator<Transport> enumerator = Transport.Where(t => t.GetID() == id).GetEnumerator();
            if (enumerator.MoveNext())
            {
                Transport.Remove(enumerator.Current);
            }
            else
            {
                throw new RemoveAutoException(String.Format("Remove unsuccessful. Item with id '{0}' not found.", id));
            }

        }
    }
}
