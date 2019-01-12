using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rejestr_Dluznikow
{
    
    [Serializable()]
    public class Dluznik : Osoba
    {
        public Dluznik() : base()
        {
            dlug_do_splaty = 0;
            zaleglych_dni = 0;
            wyslanych_ponaglen = 0;
            czy_w_sadzie = false;
        }

        public Dluznik(int Dlug_do_splaty = 0, int Zaleglych_dni = 0, int Wyslanych_ponaglen = 0, bool Czy_w_sadzie = false) : base()
        {
            this.Dlug_do_splaty = Dlug_do_splaty;
            this.Zaleglych_dni = Zaleglych_dni;
            this.Wyslanych_ponaglen = Wyslanych_ponaglen;
            this.Czy_w_sadzie = Czy_w_sadzie;
        }
        private int dlug_do_splaty;

        public int Dlug_do_splaty
        {
            get { return dlug_do_splaty; }
            set { dlug_do_splaty = value; }
        }

        private int zaleglych_dni;

        public int Zaleglych_dni
        {
            get { return zaleglych_dni; }
            set { zaleglych_dni = value; }
        }

        private int wyslanych_ponaglen;

        public int Wyslanych_ponaglen
        {
            get { return wyslanych_ponaglen; }
            set { wyslanych_ponaglen = value; }
        }

        private bool czy_w_sadzie;

        public bool Czy_w_sadzie
        {
            get { return czy_w_sadzie; }
            set { czy_w_sadzie = value; }
        }
        public string WyswietlInformacje()
        {
            return $"{this}, {wyslanych_ponaglen}, {dlug_do_splaty}, {zaleglych_dni}, {czy_w_sadzie} ";
        }
    }
}
