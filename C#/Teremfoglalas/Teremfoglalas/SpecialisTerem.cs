namespace Teremfoglalas
{
    public class SpecialisTerem : Terem
    {
        public int TakaritasIdo { get; private set; }

        public SpecialisTerem(int teremAzonosito, int helyekSzama, int takaritasIdo) : base(teremAzonosito, helyekSzama)
        {
            TakaritasIdo = takaritasIdo;
        }

        public new void IdopontFoglalas(Foglalas foglalas)
        {
            if (Orarend.Exists(f => f.Kezdete <= foglalas.Vege && f.Vege >= foglalas.Kezdete))
            {
                throw new FoglalasException();
            }

            Orarend.Add(foglalas);

            Orarend.Add(new Foglalas(foglalas.Vege, TakaritasIdo, TeremAzonosito, -1));
        }

        public override string ToString()
        {
            return $"SpecialisTerem Azonosito: {TeremAzonosito}, TakaritasIdo: {TakaritasIdo}, Orarend: {string.Join(", ", Orarend)}";
        }
    }
}