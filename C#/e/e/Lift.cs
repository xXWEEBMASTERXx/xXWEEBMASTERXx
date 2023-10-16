public class Lift : IMozog
{
    private int emeletekSzama;
    private int aktualisEmelet;
    private Random rnd;

    public Lift(int emeletekSzama)
    {
        this.emeletekSzama = emeletekSzama;
        rnd = new Random();
        aktualisEmelet = rnd.Next(1, emeletekSzama + 1);
    }

    public void Lefele()
    {
        if (aktualisEmelet == 1)
        {
            throw new HibasIranyException("A lift már az első emeleten van!");
        }
        if (rnd.Next(100) == 0)
        {
            throw new Exception("A lift elromlott");
        }
        aktualisEmelet--;
    }

    public void Felfele()
    {
        if (aktualisEmelet == emeletekSzama)
        {
            throw new HibasIranyException("A lift már az utolsó emeleten van!");
        }
        if (rnd.Next(100) == 0)
        {
            throw new Exception("A lift elromlott");
        }
        aktualisEmelet++;
    }

    public override string ToString()
    {
        return $"Aktuális emelet: {aktualisEmelet}/{emeletekSzama}";
    }
}
