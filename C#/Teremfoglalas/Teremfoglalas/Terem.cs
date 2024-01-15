namespace Teremfoglalas
{
    public class Terem
    {
        public int TeremAzonosito { get; private set; }
        public int HelyekSzama { get; private set; }
        public List<Foglalas> Orarend { get; private set; }
        public List<Foglalas> Foglalasok { get; } = new List<Foglalas>();

        public Terem(int teremAzonosito, int helyekSzama)
        {
            TeremAzonosito = teremAzonosito;
            HelyekSzama = helyekSzama;
            Orarend = new List<Foglalas>();
        }

        public void IdopontFoglalas(Foglalas foglalas)
        {
            if (Orarend.Exists(f => f.Kezdete <= foglalas.Vege && f.Vege >= foglalas.Kezdete))
            {
                throw new FoglalasException();
            }

            Orarend.Add(foglalas);
        }
    }
}