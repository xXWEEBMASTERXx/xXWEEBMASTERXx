public static class DataProcessor
{
    public static void PerformCalculations(
        List<Lake> lakes,
        List<City> cities,
        List<CityLakeMapping> mappings)
    {
        // 1. feladat: Legnagyobb területű tó kiszámítása
        var largestLake = lakes.OrderByDescending(lake => lake.Area).First();
        Console.WriteLine($"Legnagyobb tó: {largestLake.Name} területe: {largestLake.Area} km2.");

        // 2. feladat: Tavak átlagos területe típusonkénti kiszámítása
        var averageAreaByType = lakes.GroupBy(lake => lake.Type)
                                     .Select(group => new
                                     {
                                         Type = group.Key,
                                         AverageArea = group.Average(lake => lake.Area)
                                     });
        foreach (var item in averageAreaByType)
        {
            Console.WriteLine($" {item.Type} átlag területe: {item.AverageArea} km2.");
        }

        // 3. feladat: Tavak számának kiszámítása városonként
        var lakesByCity = mappings.GroupBy(mapping => mapping.CityID)
                                  .Select(group => new
                                  {
                                      CityID = group.Key,
                                      LakeCount = group.Count()
                                  });
        foreach (var item in lakesByCity)
        {
            var city = cities.First(c => c.ID == item.CityID);
            Console.WriteLine($"Város: {city.Name}, Tavak Száma: {item.LakeCount}");
        }

        // 4. feladat: Tavak kiiírása városnévvel
        var cityLakeData = from mapping in mappings
                           join lake in lakes on mapping.LakeID equals lake.ID
                           join city in cities on mapping.CityID equals city.ID
                           select new
                           {
                               CityName = city.Name,
                               LakeName = lake.Name
                           };

        foreach (var item in cityLakeData)
        {
            Console.WriteLine($"Város: {item.CityName}, Tó: {item.LakeName}");
        }
    }
}
