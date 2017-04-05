using System.IO;
using System.Web;
using System.Web.Http;

using StyleBuilderAPI.Data.Contracts;
using StyleBuilderAPI.Data.Repositories;

namespace StyleBuilderAPI.Controllers
{
    public class DefaultValuesController : ApiController
    {
        private readonly IDefaultValuesRepository defaultValues;
        private static readonly string dataPath = Path.Combine(Directory.GetParent(HttpRuntime.AppDomainAppPath).Parent.FullName, @"Data\DefaultValues");
        
        public DefaultValuesController() : this(new DefaultValuesRepository(dataPath)) { }

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
