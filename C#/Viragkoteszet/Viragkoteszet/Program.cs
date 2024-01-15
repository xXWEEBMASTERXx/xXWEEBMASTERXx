interface ITermek
{
    string TIpus { get; }
    string MEgnevezes { get; }
    int ElkeszitesiIdo { get; }
    int Ar { get; }
}

class Alapanyag
{
    public int Azonosito;
    public string Nev;
    public double Ar;
    public int ElkeszitesiIdo;

    public Alapanyag(int azonosito, string nev, double ar, int elkeszitesiIdo)
    {
        this.Azonosito = azonosito;
        this.Nev = nev;
        this.Ar = ar;
        this.ElkeszitesiIdo = elkeszitesiIdo;
    }

    public void KiirAdatok()
    {
        Console.WriteLine($"Azonosító: {Azonosito}");
        Console.WriteLine($"Név: {Nev}");
        Console.WriteLine($"Ár: {Ar} Ft");
        Console.WriteLine($"Elkészítési idő: {ElkeszitesiIdo} perc");
    }
}

class Katalogus
{
    private List<Alapanyag> alapanyagok;

    public Katalogus(List<Alapanyag> alapanyagok)
    {
        this.alapanyagok = alapanyagok;
    }

    public Alapanyag this[int azonosito]
    {
        get
        {
            foreach (var alapanyag in alapanyagok)
            {
                if (alapanyag.Azonosito == azonosito)
                {
                    return alapanyag;
                }
            }

            return null;
        }
    }
}
class Termek : ITermek
{
    public int Azonosito;
    public string Tipus;
    public string Megnevezes;
    public List<AlapanyagMennyiseg> Alapanyagok;
    public AlapanyagKatalogus AlapanyagKatalogus;

    public Termek(int azonosito, string tipus, string megnevezes, List<AlapanyagMennyiseg> alapanyagok, AlapanyagKatalogus alapanyagKatalogus)
    {
        this.Azonosito = azonosito;
        this.Tipus = tipus;
        this.Megnevezes = megnevezes;
        this.Alapanyagok = alapanyagok;
        this.AlapanyagKatalogus = alapanyagKatalogus;
    }

    public string TIpus { get { return Tipus; } }
    public string MEgnevezes { get { return Megnevezes; } }

    public int ElkeszitesiIdo
    {
        get
        {
            int osszIdo = 0;
            foreach (var alapanyagMennyiseg in Alapanyagok)
            {
                Alapanyag alapanyag = AlapanyagKatalogus[alapanyagMennyiseg.Azonosito];
                osszIdo += alapanyagMennyiseg.Mennyiseg * alapanyag.ElkeszitesiIdo;
            }
            return osszIdo;
        }
    }

    public int Ar
    {
        get
        {
            int osszAr = 0;
            foreach (var alapanyagMennyiseg in Alapanyagok)
            {
                Alapanyag alapanyag = AlapanyagKatalogus[alapanyagMennyiseg.Azonosito];
                osszAr += Convert.ToInt32(alapanyagMennyiseg.Mennyiseg * alapanyag.Ar);
            }
            return osszAr;
        }
    }

    public override string ToString()
    {
        return $"Termék: {Megnevezes} ({Tipus})\nElkészítési idő: {ElkeszitesiIdo} perc\nÁr: {Ar} Ft";
    }
}

class AlapanyagMennyiseg
{
    public int Azonosito { get; }
    public int Mennyiseg { get; }

    public AlapanyagMennyiseg(int azonosito, int mennyiseg)
    {
        Azonosito = azonosito;
        Mennyiseg = mennyiseg;
    }
}

class AlapanyagKatalogus
{
    private List<Alapanyag> alapanyagok;

    public AlapanyagKatalogus(List<Alapanyag> alapanyagok)
    {
        this.alapanyagok = alapanyagok;
    }

    public Alapanyag this[int azonosito]
    {
        get
        {
            foreach (var alapanyag in alapanyagok)
            {
                if (alapanyag.Azonosito == azonosito)
                {
                    return alapanyag;
                }
            }
            return null;
        }
    }
}

class Termekek
{
    private List<Termek> termekek;

    public Termekek(List<Termek> termekek)
    {
        this.termekek = termekek;
    }

    public Termek this[int azonosito]
    {
        get
        {
            foreach (var termek in termekek)
            {
                if (termek.Azonosito == azonosito)
                {
                    return termek;
                }
            }
            return null;
        }
    }

    public override string ToString()
    {
        string result = "Előállítható termékek:\n";
        foreach (var termek in termekek)
        {
            result += termek.ToString() + "\n";
        }
        return result;
    }
}

class FeladatLista
{
    private List<string> feladatok;

    public FeladatLista()
    {
        feladatok = new List<string>();
    }

    public static FeladatLista operator +(FeladatLista lista, string ujFeladat)
    {
        lista.feladatok.Add(ujFeladat);
        return lista;
    }

    public List<string> AktualisFeladatok
    {
        get { return feladatok; }
    }
}

class Dolgozo
{
    private int azonosito;
    private string nev;
    private int gyakorlottsag;
    private int munkaraForditottIdo;
    private List<string> feladatLista;

    public Dolgozo(int azonosito, string nev)
    {
        this.azonosito = azonosito;
        this.nev = nev;
        this.gyakorlottsag = 0;
        this.munkaraForditottIdo = 0;
        this.feladatLista = new List<string>();
    }

    public int Gyakorlottsag
    {
        get { return gyakorlottsag; }
    }

    public int MunkaraForditottIdo
    {
        get { return munkaraForditottIdo; }
    }

    public void UjFeladatHozzaadasa(string termekMegnevezes)
    {
        feladatLista.Add(termekMegnevezes);
    }

    public override string ToString()
    {
        return $"{nev} - Munkára fordított idő: {munkaraForditottIdo} perc";
    }
}

// Félkész Majd Otthon befejezem