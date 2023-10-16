public interface IMozog
{
    void Lefele();
    void Felfele();
}

public class HibasIranyException : Exception
{
    public HibasIranyException(string message) : base(message)
    {

    }
}
