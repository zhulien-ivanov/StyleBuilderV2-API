using System.IO;
using System.Web;
using System.Web.Http;

using StyleBuilderAPI.Data.Contracts;
using StyleBuilderAPI.Data.Repositories;

namespace StyleBuilderAPI.Controllers
{
    public class ColorPalettesController : ApiController
    {
        private readonly IColorPalettesRepository colorPalettes;
        private static readonly string dataPath = Path.Combine(Directory.GetParent(HttpRuntime.AppDomainAppPath).Parent.FullName, @"Data\ColorPalettes");

        public ColorPalettesController() : this(new ColorPalettesRepository(dataPath)) { }

        public ColorPalettesController(IColorPalettesRepository colorPalettesRepository)
        {
            this.colorPalettes = colorPalettesRepository;
        }

        [HttpGet]
        [Route("api/colorpalettes")]
        public IHttpActionResult GetAll()
        {
            return this.Ok(this.colorPalettes.GetAll());
        }

        [HttpGet]
        [Route("api/colorpalettes/{name}")]
        public IHttpActionResult GetByName(string name)
        {
            return this.Ok(colorPalettes.Get(name));
        }
    }
}
