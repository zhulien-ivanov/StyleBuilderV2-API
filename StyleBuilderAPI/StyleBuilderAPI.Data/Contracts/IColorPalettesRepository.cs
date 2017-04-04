namespace StyleBuilderAPI.Data.Contracts
{
    public interface IColorPalettesRepository
    {
        string Get(string colorPaletteName);

        string GetAll();
    }
}
