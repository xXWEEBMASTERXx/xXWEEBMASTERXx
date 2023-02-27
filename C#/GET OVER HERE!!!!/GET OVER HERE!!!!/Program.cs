using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET_OVER_HERE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("input.txt");
                int n = int.Parse(lines[0]);
                Lift[] liftek = new Lift[n];
                for (int i = 0; i < n; i++)
                {
                    string[] line = lines[i + 1].Split(' ');
                    int emeletekSzama = int.TryParse(line[1], out int result) ? result : 10;
                    liftek[i] = new Lift(emeletekSzama);
                }
                for (int i = n + 1; i < lines.Length; i++)
                {
                    string[] line = lines[i].Split(';');
                    int liftIndex = int.TryParse(line[0], out int result) ? result : -1;
                    if (liftIndex < 0 || liftIndex >= n)
                    {
                        Console.WriteLine("Hibás sor: " + lines[i]);
                        continue;
                    }
                    Lift lift = liftek[liftIndex];
                    string irany = line[1].Trim().ToLower();
                    try
                    {
                        if (irany == "le")
                        {
                            lift.Lefele();
                        }
                        else if (irany == "fel")
                        {
                            lift.Felfele();
                        }
                        else
                        {
                            Console.WriteLine("Hibás sor: " + lines[i]);
                        }
                        Console.WriteLine("Lift " + liftIndex + ": " + lift);
                    }
                    catch (HibasIranyException ex)
                    {
                        Console.WriteLine("Lift " + liftIndex + ": " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lift " + liftIndex + ": " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba: " + ex.Message);
            }
        }
    }
}
    }
}
