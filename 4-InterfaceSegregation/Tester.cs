namespace InterfaceSegregation
{
    public class Tester : IWorkTeamActivities, ITestActivities
    {
        public Tester()
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

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}