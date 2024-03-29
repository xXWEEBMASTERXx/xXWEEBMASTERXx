﻿using System.Text;

namespace Kemia
{
    class Vegyulet : IReakcioKepes
    {
        
        private readonly Dictionary<KemiaiElem, int> elemek;

        public Vegyulet()
        {
            elemek = new Dictionary<KemiaiElem, int>();
        }

        public void HozzaadElem(KemiaiElem elem, int mennyiseg)
        {
            if (elemek.ContainsKey(elem))
            {
                elemek[elem] += mennyiseg;
            }
            else
            {
                elemek[elem] = mennyiseg;
            }
        }

        public bool Szerves
        {
            get { return elemek.Keys.Any(elem => elem.Vegyjel == "C"); }
        }

        public bool Szénhidrát
        {
            get { return elemek.Keys.Count(elem => elem.Vegyjel == "C") == 1 && elemek.Keys.Count(elem => elem.Vegyjel == "H") == 2; }
        }

        public bool ReakciobaLephet()
        {
            foreach (var pair in elemek)
            {
                if (pair.Key.Vegyjel == "C")
                {
                    return true;
                }
            }
            return false;
        }

        public bool ReakciobaLephet(IReakcioKepes masik)
        {
            return ReakciobaLephet() && masik.ReakciobaLephet();
        }

        public override string ToString()
        {
            string result = "Vegyület összetétele:\n";
            StringBuilder builder = new(result);
            foreach (var pair in elemek)
            {

                builder.Append($"{pair.Key.Vegyjel} ({pair.Key.Rendszam}): {pair.Value}");
            }
            return builder.ToString();
        }
    }
}