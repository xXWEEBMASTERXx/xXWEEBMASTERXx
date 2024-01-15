namespace Teremfoglalas
{
    public class Foglalas : IFoglalas
    {
        public int HelyszinAzonosito { get; private set; }
        public DateTime Kezdete { get; set; }
        public DateTime Vege { get; set; }

        public int TeremAzonosito { get; private set; }
        public int TanarAzonosito { get; private set; }

        public Foglalas(DateTime kezdoIdopont, int idotartamPercek, int teremAzonosito, int tanarAzonosito)
        {
            if (idotartamPercek <= 0 || idotartamPercek % 15 != 0)
            {
                throw new IdotartamException();
            }

            Kezdete = kezdoIdopont;
            Vege = kezdoIdopont.AddMinutes(idotartamPercek);
            HelyszinAzonosito = teremAzonosito;
            TeremAzonosito = teremAzonosito;
            TanarAzonosito = tanarAzonosito;
        }
        public override string ToString()
        {
            return $"Foglalás kezdete: {Kezdete}, Vége: {Vege}, Foglaló tanár azonosítója: {TanarAzonosito}";
        }
    }
}