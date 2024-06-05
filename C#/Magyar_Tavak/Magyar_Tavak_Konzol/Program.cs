// átírtam az alloviz.txt fájlt hogy a nem ismert adat 0 legyen ha szám és ismeretlen ha szöveg
using System.Text;

StreamReader reader = new StreamReader("alloviz.txt", new UTF8Encoding(true));
List<Lake> lakes = new List<Lake>();
string sor = reader.ReadLine();
sor = reader.ReadLine();
while (!reader.EndOfStream)
{
    string[] sor2 = sor.Split('\t');
    lakes.Add(new Lake
    {
        ID = int.Parse(sor2[0]),
        Name = sor2[1],
        Type = sor2[2],
        Area = double.Parse(sor2[3]),
        WaterCollector = int.Parse(sor2[4])
    });
    sor = reader.ReadLine();
}
reader.Close();

StreamReader reader2 = new StreamReader("helykapcs.txt", new UTF8Encoding(true));
List<CityLakeMapping> cityLakeMappings = new List<CityLakeMapping>();
string sor3 = reader2.ReadLine();
sor3 = reader2.ReadLine();
while (!reader2.EndOfStream)
{
    string[] sor4 = sor3.Split('\t');
    cityLakeMappings.Add(new CityLakeMapping
    {
        CityID = int.Parse(sor4[0]),
        LakeID = int.Parse(sor4[1])
    });
    sor3 = reader2.ReadLine();
}
reader2.Close();

StreamReader reader3 = new StreamReader("telepulesgps.txt", new UTF8Encoding(true));
List<City> cities = new List<City>();
string sor5 = reader3.ReadLine();
sor5 = reader3.ReadLine();
while (!reader3.EndOfStream)
{
    string[] sor6 = sor5.Split('\t');
    cities.Add(new City
    {
        ID = int.Parse(sor6[0]),
        Name = sor6[1],
        Longitude = double.Parse(sor6[2]),
        Latitude = double.Parse(sor6[3])
    });
    sor5 = reader3.ReadLine();
}
reader3.Close();

DataProcessor.PerformCalculations(lakes, cities, cityLakeMappings);