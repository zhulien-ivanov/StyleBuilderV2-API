using System.IO;

using StyleBuilderAPI.Data.Contracts;

namespace StyleBuilderAPI.Data.Repositories
{
    public class ComponentVariablesRepository : IComponentVariablesRepository
    {
        private readonly string componentVariablesDirectory;

        public ComponentVariablesRepository(string componentVariablesDirectory)
        {
            this.componentVariablesDirectory = componentVariablesDirectory;
        }

        public string Get(string frontEnd, string componentName)
        {
            var componentFilePath = $"{this.componentVariablesDirectory}\\{frontEnd}\\{componentName}.json";

            var componentVariablesJSON = File.ReadAllText(componentFilePath);

            return componentVariablesJSON;
        }
    }
}
