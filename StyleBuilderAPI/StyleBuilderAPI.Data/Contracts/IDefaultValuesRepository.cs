namespace StyleBuilderAPI.Data.Contracts
{
    public interface IDefaultValuesRepository
    {
        string Get(string themeName, string frontEnd, string componentName);

        void Add(string themeName, string frontEnd, string componentName, string defaultValuesJSON);
    }
}
