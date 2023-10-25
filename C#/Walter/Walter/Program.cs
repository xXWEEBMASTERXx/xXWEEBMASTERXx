
try
{
    using (StreamReader sr = new StreamReader("vegyuletek.txt"))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            string[] parts = line.Split('\t');
            string vegyjel = parts[0];
            int rendszam = int.Parse(parts[1]);
            int focsoport = int.Parse(parts[2]);

            KemiaiElem elem;
            if (new string[] { "He", "Ne", "Ar", "Kr", "Xe", "Rn" }.Contains(vegyjel))
            {
                elem = new NemesGaz(vegyjel, rendszam);
            }
            else
            {
                elem = new NemFem(vegyjel, rendszam, focsoport);
            }

            Vegyulet vegyulet = new Vegyulet();
            vegyulet.HozzaadElem(elem, 1);

            Console.WriteLine(vegyulet.ToString());
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Hiba történt: " + ex.Message);
}
