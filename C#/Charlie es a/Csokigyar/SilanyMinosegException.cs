using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csokigyar
{
    public class SilanyMinosegException : Exception
    {
        public SilanyMinosegException() : base("Nem igazi csoki")
        {
        }
    }
}
