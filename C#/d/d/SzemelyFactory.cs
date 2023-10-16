public class SzemelyFactory
{
    public static Szemely CreateSzemely(string data)
    {
        string[] parts = data.Split(';');
        char type = parts[0][0];
        string nev = parts[1];
        DateTime szuletesiDatum = DateTime.Parse(parts[2]);

        if (type == 'd')
        {
            int puskakSzama = int.Parse(parts[3]);
            return new Diak(nev, szuletesiDatum, puskakSzama);
        }
        else if (type == 't')
        {
            double evvegiJegyekAtlag;
            if (double.TryParse(parts[3], out evvegiJegyekAtlag))
            {
                return new Tanar(nev, szuletesiDatum, evvegiJegyekAtlag);
            }
        }

        return null;
    }
}
