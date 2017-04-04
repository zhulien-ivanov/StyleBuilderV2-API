using System.Web.Http;

using StyleBuilderAPI.Data.Contracts;
using StyleBuilderAPI.Data.Repositories;

namespace StyleBuilderAPI.Controllers
{
    public class ComponentVariablesController : ApiController
    {
        private readonly IComponentVariablesRepository componentVariables;

        // TODO
        public ComponentVariablesController() : this(new ComponentVariablesRepository("DIRECTORY PLACEHOLDER")) { }

        public ComponentVariablesController(IComponentVariablesRepository componentVariablesRepository)
        {
            this.componentVariables = componentVariablesRepository;
        }

        [HttpGet]
        [Route("api/componentvariables/{frontEnd:string}/{name:string}")]
        public IHttpActionResult GetByName(string frontEnd, string name)
        {
            return this.Ok(this.componentVariables.Get(frontEnd, name));
        }
    }
}
