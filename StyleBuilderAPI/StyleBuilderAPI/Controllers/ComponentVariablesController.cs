using System.IO;
using System.Web;
using System.Web.Http;

using StyleBuilderAPI.Data.Contracts;
using StyleBuilderAPI.Data.Repositories;

namespace StyleBuilderAPI.Controllers
{
    public class ComponentVariablesController : ApiController
    {
        private readonly IComponentVariablesRepository componentVariables;
        private static readonly string dataPath = Path.Combine(Directory.GetParent(HttpRuntime.AppDomainAppPath).Parent.FullName, @"Data\ComponentVariables");

        public ComponentVariablesController() : this(new ComponentVariablesRepository(dataPath)) { }

        public ComponentVariablesController(IComponentVariablesRepository componentVariablesRepository)
        {
            this.componentVariables = componentVariablesRepository;
        }

        [HttpGet]
        [Route("api/componentvariables/{frontEnd}/{name}")]
        public IHttpActionResult GetByName(string frontEnd, string name)
        {
            return this.Ok(this.componentVariables.Get(frontEnd, name));
        }
    }
}
