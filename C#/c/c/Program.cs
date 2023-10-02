string filePath = "terkep.txt";
int[] adatok = File.ReadAllLines(filePath).Select(int.Parse).ToArray();
int sorokSzama = adatok.GetLength(0);
int oszlopokSzama = adatok.GetLength(1);

// 2. feladat:
Console.WriteLine("2. feladat:");
int sor = int.Parse(Console.ReadLine());
int oszlop = int.Parse(Console.ReadLine());
int sor2 = sor - 1;
int oszlop2 = oszlop - 1;
Console.WriteLine($"A {sor};{oszlop} koordinátáknál mért fényszennyezés értéke: {adatok[sor2][oszlop2]}");

// 3. feladat:
int sötétPontokSzama = 0;
for (int sor3 = 0; sor3 < sorokSzama; sor++)
{
    for (int oszlop3 = 0; oszlop3 < oszlopokSzama; oszlop++)
    {
        if (adatok[sor3][oszlop3] == 0)
        {
            sötétPontokSzama++;
        }
    }
}

double sötétPontokSzázaléka = (double)sötétPontokSzama / (sorokSzama * oszlopokSzama) * 100;

Console.WriteLine($"3. feladat: A terület {sötétPontokSzázaléka:0.1f}%-a sötét teljesen.");

// 4. feladat:
int legnagyobbFényszennyezés = 0;
int[] legnagyobbFényszennyezésKoordinatái = new int[2];
for (int sor4 = 0; sor4 < sorokSzama; sor++)
{
    for (int oszlop4 = 0; oszlop4 < oszlopokSzama; oszlop++)
    {
        if (adatok[sor4][oszlop4] > legnagyobbFényszennyezés)
        {
            legnagyobbFényszennyezés = adatok[sor4][oszlop4];
            legnagyobbFényszennyezésKoordinatái[0] = sor + 1;
            legnagyobbFényszennyezésKoordinatái[1] = oszlop + 1;
        }
    }
}

Console.WriteLine($"4. feladat: A legnagyobb fényszennyezés értéke: {legnagyobbFényszennyezés}, a koordinátái: {legnagyobbFényszennyezésKoordinatái[0]};{legnagyobbFényszennyezésKoordinatái[1]}");

// 5. feladat:
bool fényes(int sor, int oszlop)
{
    int szomszédokSzáma = 0;

    if (sor > 0 && oszlop > 0 && adatok[sor2][oszlop2] <= adatok[sor][oszlop])
    {
        szomszédokSzáma++;
    }

    if (sor > 0 && adatok[sor2][oszlop] <= adatok[sor][oszlop])
    {
        szomszédokSzáma++;
    }

    if (sor < sorokSzama - 1 && adatok[sor + 1][oszlop] <= adatok[sor][oszlop])
    {
        szomszédokSzáma++;
    }

    if (oszlop < oszlopokSzama - 1 && adatok[sor][oszlop + 1] <= adatok[sor][oszlop])
    {
        szomszédokSzáma++;
    }

    return szomszédokSzáma < adatok[sor][oszlop];
}

int fényesPontokSzáma = 0;
for (int sor5 = 0; sor5 < sorokSzama; sor++)
{
    for (int oszlop5 = 0; oszlop5 < oszlopokSzama; oszlop++)
    {
        if (fényes(sor, oszlop))
        {
            fényesPontokSzáma++;
        }
    }
}

Console.WriteLine($"5. feladat: A fényes mérési pontok száma: {fényesPontokSzáma}");

// 7. feladat:
int oszlopSorszáma = int.Parse(Console.ReadLine());

string fájlÚtvonal = "diagram.txt";
File.WriteAllLines(fájlÚtvonal, new string[] { "Oszlopok: 1 2 3 4 5" });

for (int sor7 = 0; sor7 < sorokSzama; sor++)
{
    if (adatok[sor7][oszlopSorszáma] != 0)
    {
        int fényesség = Math.Round(adatok[sor7][oszlopSorszáma], 1);

        string sorTartalom = "";
        for (int i = 0; i < fényesség; i++)
        {
            sorTartalom += "*";
        }

        File.AppendAllText(fájlÚtvonal, sorTartalom + "\n");
    }
}
