using System.Linq;

namespace Teremfoglalas
{
    public  class TeremNyilvantartas
    {
        private readonly List<Terem> termekek = new List<Terem>();
        private readonly List<Foglalas> foglalasok = new List<Foglalas>();
        public IEnumerable<int> TermekAzonositoi => termekek.Select(t => t.TeremAzonosito);
        public Terem this[int teremAzonosito]
        {
            get
            {
                var foundTerem = termekek.Find(t => t.TeremAzonosito == teremAzonosito);
                if (foundTerem == null)
                {
                    throw new InvalidOperationException($"Terem with azonosito {teremAzonosito} not found.");
                }
                return foundTerem;
            }
        }

        public IEnumerable<Terem> OsszesTerem => termekek;

        public void TeremFoglalasok(IEnumerable<Foglalas> ujFoglalasok)
        {
            foreach (var foglalas in ujFoglalasok)
            {
                try
                {
                    var terem = termekek.Find(t => t.TeremAzonosito == foglalas.HelyszinAzonosito);

                    if (terem != null)
                    {
                        terem.IdopontFoglalas(foglalas);
                        foglalasok.Add(foglalas);
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText("hibalista.txt"))
                        {
                            sw.WriteLine($"Hiba: A terem azonosítója nem található - {foglalas}");
                        }
                    }
                }
                catch (FoglalasException ex)
                {
                    using (StreamWriter sw = File.AppendText("hibalista.txt"))
                    {
                        sw.WriteLine($"Hiba: {ex.Message} - {foglalas}");
                    }
                }
            }
        }
        public void TeremHozzaad(Terem terem)
        {
            termekek.Add(terem);
        }
        public IEnumerable<Terem> GetTermek()
        {
            return termekek;
        }
        public void MindenTeremOra()
        {
            foreach (var (terem, foglalasok1) in from terem in termekek
                                                 let foglalasok1 = GetTermek()
                                                 select (terem, foglalasok1))
            {
                if (foglalasok1.Any())
                {
                    Console.WriteLine($"Terem {terem.TeremAzonosito} összes foglalása:");
                    foreach (var foglalas in foglalasok1)
                    {
                        Console.WriteLine(foglalas);
                    }
                }
                else
                {
                    Console.WriteLine($"Nincs foglalás a teremben {terem.TeremAzonosito}.");
                }
            }
        }
        public void TanarTeremfoglalasai(int tanarAzonosito)
        {
            foreach (var terem in termekek)
            {
                var tanarFoglalasok = terem.Foglalasok.Where(f => f.TanarAzonosito == tanarAzonosito);

                if (tanarFoglalasok.Any())
                {
                    Console.WriteLine($"Terem {terem.TeremAzonosito} foglalásai a tanárhoz ({tanarAzonosito}):");
                    foreach (var foglalas in tanarFoglalasok)
                    {
                        Console.WriteLine(foglalas);
                    }
                }
                else
                {
                    Console.WriteLine($"Nincs foglalás a teremben {terem.TeremAzonosito} a tanárhoz ({tanarAzonosito}).");
                }
            }
        }
    }
}