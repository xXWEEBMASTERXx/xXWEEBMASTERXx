public class Szeleromuvek
{
    public List<Szeleromu> SzeleromuvekLista { get; set; }

    public Szeleromuvek(string adatfajl)
    {
        SzeleromuvekLista = new List<Szeleromu>();

        using (StreamReader reader = new StreamReader(adatfajl))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var adatok = line.Split(';');
                string regio = adatok[0];
                string megye = adatok[1];
                string telepules = adatok[2];
                int darab = int.Parse(adatok[3]);
                int teljesitmeny = int.Parse(adatok[4]);
                int ev = int.Parse(adatok[5]);

                var szeleromu = new Szeleromu(regio, megye, telepules, darab, teljesitmeny, ev);
                SzeleromuvekLista.Add(szeleromu);
            }
        }
    }
}
