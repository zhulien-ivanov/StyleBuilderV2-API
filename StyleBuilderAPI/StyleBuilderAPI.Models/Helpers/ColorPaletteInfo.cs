namespace StyleBuilderAPI.Models.Helpers
{
    public class ColorPaletteInfo
    {
        private string name;
        private string imagePath;

        public ColorPaletteInfo(string name, string imagePath)
        {
            this.Name = name;
            this.ImagePath = imagePath;
        }

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
    }
}
