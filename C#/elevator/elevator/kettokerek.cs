using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    class kettokerek
    {
        protected double hossz;
        public kettokerek()
        {
            hossz = 2;
        }

        public kettokerek(double h)
        {
            hossz = h;
        }
        public virtual void Jelez()
        {


        }
    }

    class Bringa : kettokerek
    {
        int maxSeb;
        public Bringa(int km)
        {
            maxSeb = km;
        }
        
        public Bringa(double h): base (h)
        {
            /*hossz = h;*/
        }

        public override void Jelez()
        {
            Console.WriteLine("Csengetek");
        }
    }

}
