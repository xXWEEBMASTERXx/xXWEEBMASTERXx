using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace I_live_in_Spain_without_the_a
{
    class Program
    {
        protected Program()
        {
        }

        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a fájl nevét:");
            string? fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("You entered a null value for the file name.");
            }
            else
            {
                List<Racer> racers = new List<Racer>();
                List<Racer> eliminatedRacers = new List<Racer>();

                int laps, numRacers;
                string[] lines = File.ReadAllLines(fileName);

                if (lines.Length < 2)
                {
                    Console.WriteLine("Hibás fájlformátum.");
                    return;
                }

                if (!int.TryParse(lines[0].Split(' ')[0], out laps) || !int.TryParse(lines[0].Split(' ')[1], out numRacers))
                {
                    Console.WriteLine("Hibás fájlformátum.");
                    return;
                }

                for (int i = 1; i <= numRacers; i++)
                {
                    string[] racerData = lines[i].Split(' ');
                    if (racerData.Length != 2 || !int.TryParse(racerData[1], out int category))
                    {
                        Console.WriteLine("Hibás fájlformátum.");
                        return;
                    }

                    racers.Add(new Racer { Name = racerData[0], Category = category, Fuel = 100, IsOut = false, SuccessfulOvertakes = 0 });
                }

                for (int lap = 1; lap <= laps; lap++)
                {
                    Console.WriteLine($"Kör {lap} eredménye:");

                    racers = racers.OrderBy(r => r.Fuel).ToList();

                    foreach (Racer racer in racers)
                    {
                        if (!racer.IsOut)
                        {
                            SimulateMove(racer);
                        }

                        Console.WriteLine($"{racer.Name}: {racer.Fuel} üzemanyag, {(racer.IsOut ? "Kiesett" : "Versenyben")}");
                    }

                    eliminatedRacers.AddRange(racers.Where(r => r.IsOut));
                    racers = racers.Where(r => !r.IsOut).ToList();
                }

                Console.WriteLine("\nBaleset miatt kiesők:");
                foreach (Racer eliminated in eliminatedRacers)
                {
                    Console.WriteLine(eliminated.Name);
                }

                racers = racers.OrderBy(r => r.Fuel).ToList();

                Console.WriteLine("\nAz első három helyezett:");
                for (int i = 0; i < Math.Min(3, racers.Count); i++)
                {
                    Console.WriteLine($"{i + 1}. hely: {racers[i].Name}");
                }
            }

        }



        static void SimulateMove(Racer racer)
        {
            switch (racer.Category)
            {
                case 1: // Agresszív
                    if (random.Next(2) == 0)
                    {
                        int overtakeChance = random.Next(3);
                        if (overtakeChance == 0)
                        {
                            racer.SuccessfulOvertakes++;
                            racer.Fuel -= 4;
                        }
                    }
                    break;

                case 2: // Lendületes
                    if (random.Next(5) == 0)
                    {
                        int overtakeChance = random.Next(2);
                        if (overtakeChance == 0)
                        {
                            racer.SuccessfulOvertakes++;
                            racer.Fuel -= 4;
                        }
                    }
                    break;

                case 3: // Veszélyes
                    if (random.Next(4) == 0)
                    {
                        int overtakeChance = random.Next(4);
                        if (overtakeChance == 0)
                        {
                            racer.SuccessfulOvertakes++;
                            racer.Fuel -= 8;
                        }
                    }
                    break;

                case 4: // Óvatos
                    if (racer.Fuel <= 20)
                    {
                        racer.Fuel = 100;
                    }
                    break;
            }

            if (racer.Fuel <= 0)
            {
                racer.Fuel = 100;
                racer.IsOut = true;
            }
        }
    }
}