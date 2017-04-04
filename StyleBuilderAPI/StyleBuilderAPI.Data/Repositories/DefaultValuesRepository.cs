using System.IO;

using StyleBuilderAPI.Data.Contracts;

namespace StyleBuilderAPI.Data.Repositories
{
    public class DefaultValuesRepository : IDefaultValuesRepository
    {
        private readonly string defaultValuesDirectory;

        public DefaultValuesRepository(string defaultValuesDirectory)
        {
            this.defaultValuesDirectory = defaultValuesDirectory;
        }

        public void Add(string themeName, string frontEnd, string componentName, string defaultValuesJSON)
        {
            var defaultsValuesPath = $"{this.defaultValuesDirectory}\\{themeName}\\{frontEnd}\\{componentName}.json";

            File.WriteAllText(defaultsValuesPath, defaultValuesJSON);
        }

        public string Get(string themeName, string frontEnd, string componentName)
        {
            var defaultsValuesPath = $"{this.defaultValuesDirectory}\\{themeName}\\{frontEnd}\\{componentName}.json";

            var defaultValuesJSON = File.ReadAllText(defaultsValuesPath);

            return defaultValuesJSON;
        }
    }
}
