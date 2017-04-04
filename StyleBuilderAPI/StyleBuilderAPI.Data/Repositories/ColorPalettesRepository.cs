using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using StyleBuilderAPI.Data.Contracts;
using StyleBuilderAPI.Models.Helpers;

namespace StyleBuilderAPI.Data.Repositories
{
    public class ColorPalettesRepository : IColorPalettesRepository
    {
        private readonly string colorPalettesDirectory;

        public ColorPalettesRepository(string colorPalettesDirectory)
        {
            this.colorPalettesDirectory = colorPalettesDirectory;
        }

        public string Get(string colorPaletteName)
        {
            var colorPalettePath = $"{this.colorPalettesDirectory}\\{colorPaletteName}.json";

            var colorPaletteJSON = File.ReadAllText(colorPalettePath);

            return colorPaletteJSON;
        }

        public string GetAll()
        {
            var colorPalettesInfos = new List<ColorPaletteInfo>();

            var colorPalettePaths = Directory.GetFiles(this.colorPalettesDirectory);

            foreach (var colorPalettePath in colorPalettePaths)
            {
                var colorPaletteJSON = File.ReadAllText(colorPalettePath);
                var colorPaletteObject = JsonConvert.DeserializeObject<ColorPalette>(colorPaletteJSON);

                var colorPaletteInfo = new ColorPaletteInfo(colorPaletteObject.Name, colorPaletteObject.ImagePath);
                colorPalettesInfos.Add(colorPaletteInfo);
            }

            var colorPalettesInfosJSON = JsonConvert.SerializeObject(colorPalettesInfos);

            return colorPalettesInfosJSON;
        }
    }
}
