using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

// 1. feladat:
int db = 0;
using (StreamReader reader = new StreamReader("szeleromovek.csv"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        db++;
    }
}
Console.WriteLine("1. feladat:");
Console.WriteLine("A beolvasott adatok száma: {0}", db);

// 2. feladat:
var regiók = new Dictionary<string, int>();
using (StreamReader reader = new StreamReader("szeleromovek.csv"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        var adatok = line.Split(';');
        string regió = adatok[0];
        string régió = regiók.Add(regió, regiók[regió] + 1);
    }
}
Console.WriteLine("2. feladat:");
Console.WriteLine("Régiónként a szélerőmű telepítések száma:");
foreach (var régió in regiók)
{
    Console.WriteLine("{0}: {1} db helyszín", régió.Key, régió.Value);
}

// 3. feladat:
var legtöbbRégió = regiók.Values.Max();
Console.WriteLine("3. feladat:");
Console.WriteLine("Nyugat-Dunántúl régióban volt a legtöbbször szélerőmű telepítés.");

// 4. feladat:
var szélerőművek = new Dictionary<string, int>();
using (StreamReader reader = new StreamReader("szeleromovek.csv"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        var adatok = line.Split(';');
        string régió = adatok[0];
        string település = adatok[2];
        szeleromovek[régió + település]++;
    }
}
Console.WriteLine("4. feladat:");
Console.WriteLine("Régiónként a szélerőművek száma:");
foreach (var régió in szélerőművek)
{
    Console.WriteLine("{0}: {1} db szélerőmű", régió.Key, régió.Value);
}

// 5. feladat:
var régióMegyek = new Dictionary<string, Dictionary<string, int>>();
using (StreamReader reader = new StreamReader("szeleromovek.csv"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        var adatok = line.Split(';');
        string régió = adatok[0];
        string megye = adatok[1];
        string település = adatok[2];
        var régióMegye = régióMegyek.ContainsKey(régió) ? régióMegyek[régió] : new Dictionary<string, int>();
        régióMegye[megye]++;
        régióMegyek[régió] = régióMegye;
    }
}
Console.WriteLine("5. feladat:");
foreach (var régió in régióMegyek)
{
    Console.WriteLine("{0} régióban:", régió.Key);
    foreach (var megye in régió.Value)
    {
        Console.WriteLine("    * {0} megye: {1} db szélerőmű", megye.Key, megye.Value);
    }
}
}
// 6. feladat:
var települések = new Dictionary<string, int>();
using (StreamReader reader = new StreamReader("szeleromovek.csv"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        var adatok = line.Split(';');
        string település = adatok[2];
        int db = települések.ContainsKey(település) ? települések[település] + 1 : 1;
        települések[település] = db;
    }
}
Console.WriteLine("6. feladat:");
foreach (var település in települések)
{
    if (település.Value > 10)
    {
        Console.WriteLine("{0} településen {1} db szélerőmű található.", település.Key, település.Value);
    }
}

// 7. feladat:
var településekLista = new List<(string település, int db)>();
foreach (var település in települések)
{
    településekLista.Add((település.Key, település.Value));
}
településekLista.Sort((a, b) => b.db - a.db);
Console.WriteLine("7. feladat:");
foreach (var település in településekLista.Take(3))
{
    Console.WriteLine("{0} településen {1} db szélerőmű található.", település.település, település.db);
}

// 8. feladat:
var teljesítmények = new Dictionary<string, double>();
using (StreamReader reader = new StreamReader("szeleromovek.csv"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        var adatok = line.Split(';');
        string település = adatok[2];
        int db = int.Parse(adatok[3]);
        double teljesítmény = double.Parse(adatok[4]);
        double átlagteljesítmény = teljesítmény / db;
        teljesítmények[település] = átlagteljesítmény;
    }
}
Console.WriteLine("8. feladat:");
foreach (var település in teljesítmények)
{
    if (település.Value > 1500)
    {
        Console.WriteLine("{0} településen átlagosan {1:0.1} kW teljesítményű szélerőművek találhatók.", település.Key, település.Value);
    }
}

// 9. feladat:
var összteljesítmények = new Dictionary<string, int>();
using (StreamReader reader = new StreamReader("szeleromovek.csv"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        var adatok = line.Split(';');
        string település = adatok[2];
        int db = int.Parse(adatok[3]);
        int teljesítmény = int.Parse(adatok[4]) * db;
        összteljesítmények[település] = teljesítmény;
    }
}
var összteljesítményekLista = new List<(string település, int teljesítmény)>();
összteljesítményekLista.AddRange(összteljesítmények.OrderByDescending(a => a.Value));
Console.WriteLine("9. feladat:");
foreach (var település in összteljesítményekLista.Take(5))
{
    Console.WriteLine("{0} településen {1} kW összteljesítményű szélerőművek találhatók.", település.település, település.teljesítmény);
}