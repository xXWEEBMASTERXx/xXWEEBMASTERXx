using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csokigyar
{
    public class EtelFactory
    {
        public IEtel Factory(string adatSor)
        {
            string[] adatElemek = adatSor.Split(';');
            if (adatElemek[^1] == "prémium")
            {
                return new PremiumCsoki(
                    adatElemek[0],
                    kakaoTartalom: int.Parse(adatElemek[1]),
                    alapanyagok: adatElemek[2..^1]
                    );
            }
            return new Csoki(
                adatElemek[0],
                kakaoTartalom: int.Parse(adatElemek[1]),
                alapanyagok: adatElemek[2..]
                );
        }
    }
}
