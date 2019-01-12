using System;
using System.IO;
using System.Xml.Serialization;

namespace Rejestr_Dluznikow
{
    class Program
    {
        static void Main(string[] args)
        {
            AddDebtor();
            
            Console.Read();
        }

        static void AddDebtor()
        {
            Dluznik a1 = new Dluznik(12, 32, 12, true);
            Dluznik a2 = new Dluznik(141242, 312, 12, false);
            Dluznik a3 = new Dluznik(1214124122, 32132, 212, false);
            Console.WriteLine(a1.WyswietlInformacje());
            Console.WriteLine(Serialize(a1));
            Console.WriteLine(Serialize(a2));
            Console.WriteLine(Serialize(a3));
        }

        static string Serialize(Object clasa)
        {
            XmlSerializer xmlFormattter = new XmlSerializer(typeof(Osoba), new Type[] { typeof(Dluznik), typeof(Firma) });
            using(Stream fStream = new FileStream("Serializable.xml",FileMode.Create, FileAccess.Write))
            {
                xmlFormattter.Serialize(fStream, clasa);
            }

            return "Zserliaziowano";
        }
    }
}
