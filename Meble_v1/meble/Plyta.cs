using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meble_v_1.meble
{
    public class Plyta
    {
        public enum Boki { SZEROKOSC_1, SZEROKOSC_2, SZEROKOSC_3, SZEROKOSC_4 };

        private int grubosc { get; set; }
        private int szerokosc { get; set; }
        private int wysokosc { get; set; }

        public bool[] okleina;

        public Plyta( int zadana_grubosc, int zadana_szerokosc, int zadana_glebokosc, bool szerokosc_1, bool szerokosc_2, bool wysokosc_1, bool wysokosc_2)
        {
            this.grubosc = zadana_grubosc;
            this.szerokosc = zadana_szerokosc;
            this.wysokosc = zadana_glebokosc;

            okleina = new bool[4];
            okleina[0] = szerokosc_1;
            okleina[1] = szerokosc_2;
            okleina[2] = wysokosc_1;
            okleina[3] = wysokosc_2;

        }
    }
}
