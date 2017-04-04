namespace StyleBuilderAPI.Data.Contracts
{
    public interface IComponentVariablesRepository
    {
        string Get(string frontEnd, string componentName);
    }
}
