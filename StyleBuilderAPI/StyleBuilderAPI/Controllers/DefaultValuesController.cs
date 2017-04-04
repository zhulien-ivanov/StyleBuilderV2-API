using StyleBuilderAPI.Data.Contracts;
using StyleBuilderAPI.Data.Repositories;

using System.Web.Http;

namespace StyleBuilderAPI.Controllers
{
    public class DefaultValuesController : ApiController
    {
        private readonly IDefaultValuesRepository defaultValues;

        // TODO
        public DefaultValuesController() : this(new DefaultValuesRepository(@"..\Data\DefaultValues")) { }

        public DefaultValuesController(IDefaultValuesRepository defaultValuesRepository)
        {
            this.defaultValues = defaultValuesRepository;
        }

        [HttpGet]
        [Route("api/defaultvalues/{themeName}/{frontEnd}/{name}")]
        public IHttpActionResult GetByName(string themeName, string frontEnd, string name)
        {
            return this.Ok(this.defaultValues.Get(themeName, frontEnd, name));
        }

        [HttpPost]
        [Route("api/defaultvalues/{themeName}/{frontEnd}/{name}")]
        public IHttpActionResult AddByName(string themeName, string frontEnd, string name, [FromBody]string JSONbody)
        {
            this.defaultValues.Add(themeName, frontEnd, name, JSONbody);
            return this.Ok();
        }
    }
}
