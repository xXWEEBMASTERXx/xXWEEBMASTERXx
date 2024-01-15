
using Teremfoglalas;

File.WriteAllText("hibalista.txt", string.Empty);

List<Terem> termekek = BeolvasTeremek("termek.txt");

List<Foglalas> foglalasok = BeolvasFoglalasok("foglalasok.txt");

TeremNyilvantartas teremNyilvantartas = new TeremNyilvantartas();

foreach (var terem in termekek)
{
    teremNyilvantartas.TeremHozzaad(terem);
}

teremNyilvantartas.TeremFoglalasok(foglalasok);

Console.WriteLine("a. Az iskola teremazonosítói:");
foreach (var teremAzonosito in teremNyilvantartas.TermekAzonositoi)
{
    Console.WriteLine(teremAzonosito);
}

Console.WriteLine("\nb. Sikeres teremfoglalások:");
teremNyilvantartas.MindenTeremOra();

Console.Write("\nc. Adja meg egy tanár azonosítóját: ");
int tanarAzonosito = int.Parse(Console.ReadLine());
Console.WriteLine($"\nSikeres teremfoglalások a tanárhoz ({tanarAzonosito}):");
teremNyilvantartas.TanarTeremfoglalasai(tanarAzonosito);

static List<Terem> BeolvasTeremek(string fajlnev)
{
    List<Terem> termekek = new List<Terem>();

    try
    {
        using (StreamReader sr = new StreamReader(fajlnev))
        {
            string sor;
            while ((sor = sr.ReadLine()) != null)
            {
                string[] adatok = sor.Split(';');
                int teremAzonosito = int.Parse(adatok[0]);
                int helyekSzama = int.Parse(adatok[1]);
                int takaritasIdo = int.Parse(adatok[2]);

                if (helyekSzama > 0 && takaritasIdo >= 0)
                {
                    Terem terem = new Terem(teremAzonosito, helyekSzama);
                    termekek.Add(terem);
                }
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Hiba a teremek beolvasásakor: {e.Message}");
    }

    return termekek;
}

static List<Foglalas> BeolvasFoglalasok(string fajlnev)
{
    List<Foglalas> foglalasok = new List<Foglalas>();

    try
    {
        using (StreamReader sr = new StreamReader(fajlnev))
        {
            string sor;
            while ((sor = sr.ReadLine()) != null)
            {
                string[] adatok = sor.Split(';');

                if (adatok.Length >= 4 &&
                    int.TryParse(adatok[0], out int kezdoIdopont) &&
                    int.TryParse(adatok[1], out int idotartamPercek) &&
                    int.TryParse(adatok[2], out int teremAzonosito) &&
                    int.TryParse(adatok[3], out int tanarAzonosito))
                {
                    if (idotartamPercek > 0 && teremAzonosito >= 0)
                    {
                        DateTime kezdoIdopontDateTime = DateTime.Parse(adatok[0]);

                        Foglalas foglalas = new Foglalas(kezdoIdopontDateTime, idotartamPercek, teremAzonosito, tanarAzonosito);
                        foglalasok.Add(foglalas);
                    }
                }
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Hiba a foglalások beolvasásakor: {e.Message}");
    }

    return foglalasok;
}
