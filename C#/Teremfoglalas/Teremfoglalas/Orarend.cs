namespace Teremfoglalas
{
    public class Orarend
    {
        private readonly List<Foglalas> foglalasok = new List<Foglalas>();

        public bool FoglaltE(DateTime kezdoIdopont, int idotartamPercek)
        {
            DateTime vegIdopont = kezdoIdopont.AddMinutes(idotartamPercek);

            return foglalasok.Exists(foglalas =>
                kezdoIdopont >= foglalas.Kezdete && kezdoIdopont < foglalas.Vege ||
                vegIdopont > foglalas.Kezdete && vegIdopont <= foglalas.Vege ||
                kezdoIdopont <= foglalas.Kezdete && vegIdopont >= foglalas.Vege
            );
        }

        public static Orarend operator +(Orarend orarend, Foglalas foglalas)
        {
            if (orarend.FoglaltE(foglalas.Kezdete, (int)(foglalas.Vege - foglalas.Kezdete).TotalMinutes))
            {
                throw new FoglalasException();
            }

            orarend.foglalasok.Add(foglalas);
            return orarend;
        }

        public override string ToString()
        {
            var foglaltIdopontok = foglalasok.OrderBy(foglalas => foglalas.Kezdete)
                                             .Select(foglalas => $"{foglalas.Kezdete} - {foglalas.Vege}")
                                             .ToList();

            return string.Join(", ", foglaltIdopontok);
        }
    }
}