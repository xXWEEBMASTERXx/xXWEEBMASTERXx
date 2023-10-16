public interface IVizsgalat
{
    bool JoAlanyE();
}
public class HibasEletkorException : Exception
{
    public HibasEletkorException() : base("Az életkor beállítása nem megfelelő!") { }
}