using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rejestr_Dluznikow
{
    [Serializable()]
    [XmlInclude(typeof(Dluznik))]
    [XmlInclude(typeof(Firma))]
    public class Osoba
    {
        public Osoba()
        {
            Imie = "";
            Nazwisko = "";
            Adres = "";
        }

        public Osoba(string Imie = "", string Nazwisko = "", string Adres = "")
        {

        }

        private string imie;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        private string nazwisko;

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        private string adres;

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

    }
}
