using System.Collections.Generic;

namespace StyleBuilderAPI.Models.Helpers
{
    public class ColorPalette
    {
        private string name;
        private string imagePath;
        private List<ColorPaletteVariable> variables;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string ImagePath
        {
            get { return this.imagePath; }
            set { this.imagePath = value; }
        }

        public List<ColorPaletteVariable> Variables
        {
            get { return this.variables; }
            set { this.variables = value; }
        }
    }
}
