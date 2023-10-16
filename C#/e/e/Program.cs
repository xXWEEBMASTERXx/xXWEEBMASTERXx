
try
{
    var lines = File.ReadAllLines("input.txt");
    int liftsCount = int.Parse(lines[0]);
    var liftek = new List<Lift>();

    for (int i = 1; i <= liftsCount; i++)
    {
        liftek.Add(new Lift(int.Parse(lines[i])));
    }

    var liftekManager = new Liftek(liftek);

    for (int i = liftsCount + 1; i < lines.Length; i++)
    {
        var parts = lines[i].Split(';');
        if (parts.Length != 2)
        {
            Console.WriteLine("Hibás sor");
            continue;
        }
        int liftIndex;
        if (!int.TryParse(parts[0], out liftIndex) || liftIndex < 1 || liftIndex > liftsCount)
        {
            Console.WriteLine("Hibás sor");
            continue;
        }
        var lift = liftekManager[liftIndex];
        try
        {
            if (parts[1] == "le")
            {
                lift.Lefele();
            }
            else if (parts[1] == "fel")
            {
                lift.Felfele();
            }
            Console.WriteLine(lift);
        }
        catch (HibasIranyException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
catch (FileNotFoundException e)
{
    Console.WriteLine($"Hiba a fájl beolvasása során: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Ismeretlen hiba történt: {e.Message}");
}
