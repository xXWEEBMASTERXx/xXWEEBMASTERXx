namespace Teremfoglalas
{
    public class AltalanosTerem : Terem
    {
        public AltalanosTerem(int teremAzonosito, int helyekSzama) : base(teremAzonosito, helyekSzama)
        {
        }

        public new void IdopontFoglalas(Foglalas foglalas)
        {
            if (Orarend.Exists(f => f.Kezdete <= foglalas.Vege && f.Vege >= foglalas.Kezdete))
            {
                throw new FoglalasException();
            }

            Orarend.Add(foglalas);
        }

        public override string ToString()
        {
            return $"AltalanosTerem Azonosito: {TeremAzonosito}, Orarend: {string.Join(", ", Orarend)}";
        }
    }
}