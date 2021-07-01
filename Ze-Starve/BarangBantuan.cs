using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fauzan Reza Arnanda
//1302194003
    
namespace Ze_Starve
{
    class BarangBantuan
    {
         public enum Barang
        {
            NasiLiwet,
            NasiPadang,
            LontongSayur,
            KupatTahu,
            TepungTerigu,
            SemurDaging,
            NasiGudeg,
            BerasPutih,
            NasiLemak,
            BuburAyam,
            MieAyam,
            BerasKetan,
            Ketoprak,
            PecelLele,
            NasiKuning,
            BerasMerah,
            kolak,
            NasiSateMaranggi,
            MieAceh,
            NasiTimbelKomplit

        };
        public static string getKodeBarang(Barang inputbarang)
        {
          string[] codebrg = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00", "P00", "Q00", "R00", "S00", "T00" };


            return codebrg[(int)inputbarang];
        }

    }
}
