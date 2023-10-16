Nyilvantartas nyilvantartas = new Nyilvantartas();

try
{
    using (StreamReader reader = new StreamReader("input.txt"))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            try
            {
                Szemely szemely = SzemelyFactory.CreateSzemely(line);
                nyilvantartas.AddSzemely(szemely);
                Console.WriteLine(szemely);
            }
            catch (HibasEletkorException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    Console.WriteLine($"Diákok száma: {nyilvantartas.Diakok.Count}");
    Console.WriteLine($"Tanárok száma: {nyilvantartas.Tanarok.Count}");
    double atlagEletkor = nyilvantartas.Tanarok.Average(t => t.Kor);
    Console.WriteLine($"Tanárok átlagos életkora: {atlagEletkor:F2} év");

    var diakGroups = nyilvantartas.Diakok.GroupBy(d => d.PuskakSzama);
    foreach (var group in diakGroups)
    {
        Console.WriteLine($"Diákok száma {group.Key} puskával: {group.Count()}");
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Reptile Wins");
Console.WriteLine("Fatality");
