using System.Web.Http;

using StyleBuilderAPI.Data.Contracts;
using StyleBuilderAPI.Data.Repositories;

namespace StyleBuilderAPI.Controllers
{
    public class ColorPalettesController : ApiController
    {
        private readonly IColorPalettesRepository colorPalettes;

        // TODO
        public ColorPalettesController() : this(new ColorPalettesRepository("DIRECTORY PLACEHOLDER")) { }

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
        [Route("api/colorpalettes/{name:string}")]
        public IHttpActionResult GetByName(string name)
        {
            return this.Ok(colorPalettes.Get(name));
        }
    }
}
