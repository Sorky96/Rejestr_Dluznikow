using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestr_Dluznikow
{
    [Serializable()]
    public class Firma : Osoba
    {
        public Firma()
        {
            nazwa_firmy = "";
        }
        public Firma(string Nazwa_firmy = "")
        {

        }
        private string nazwa_firmy;

        public string Nazwa_firmy
        {
            get { return nazwa_firmy; }
            set { nazwa_firmy = value; }
        }

    }
}
