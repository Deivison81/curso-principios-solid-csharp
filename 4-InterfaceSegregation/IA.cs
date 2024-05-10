namespace InterfaceSegregation
{
    public class IA : IWorkTeamActivities, IIAActivities
    {
        public IA()
        {
            
        }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }

        void IIAActivities.IA()
        {
            throw new NotImplementedException();
        }
    }
}