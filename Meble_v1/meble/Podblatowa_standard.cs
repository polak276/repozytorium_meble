using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meble_v_1.meble;

namespace Meble_v_1.meble
{
    public class Podblatowa_standard : Szafka, Polka
    {

        public Podblatowa_standard(int zadana_grubosc_plyty, int zadana_szerokosc, int zadana_wysokosc, int zadana_glebokosc )
        {
            grubosc_plyty_szafki = zadana_grubosc_plyty;
            szerokosc_szafki = zadana_szerokosc;
            wysokosc_szafki = zadana_wysokosc;
            glebokosc_szafki = zadana_glebokosc;
        }

        public override List<Plyta> oblicz_plyty_dla_szafki()
        {
            List<Plyta> lista_plyt = new List<Plyta>();

            lista_plyt.AddRange(wyznacz_spod_boki_stezenia());

            lista_plyt.Add(wyznacz_polke());

            return lista_plyt;
        }

        public Plyta wyznacz_polke()
        {
            int szerokosc_polki = wyznacz_szerokosc_polki();
            int glebokosc_polki = wyznacz_glebokosc_polki();

            Plyta polka = new Plyta(grubosc_plyty_szafki, szerokosc_polki, glebokosc_polki, true, true, false, false);

            return polka;
        }

        public int wyznacz_szerokosc_polki()
        {
            return (szerokosc_szafki - 2* grubosc_plyty_szafki);
        }

        public int wyznacz_glebokosc_polki()
        {
            const int dystans = 10;

            return (glebokosc_szafki - dystans);
        }

    }
}
