namespace Teremfoglalas
{
    public interface IFoglalas
    {
        int HelyszinAzonosito { get; }
        DateTime Kezdete { get; set; }
        DateTime Vege { get; set; }
    }
}