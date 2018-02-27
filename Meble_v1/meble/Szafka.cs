using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meble_v_1.meble;

namespace Meble_v_1.meble
{
    public abstract class Szafka
    {
        public enum rodzaje_szafek { PODBLATOWA_STANDARD };

        const int wysokosc_stezenia = 100;

        protected int ilosc_stezen { get; set; }

        protected int grubosc_plyty_szafki { get; set; }
        protected int szerokosc_szafki { get; set; }
        protected int wysokosc_szafki { get; set; }
        protected int glebokosc_szafki { get; set; }

        public abstract List<Plyta> oblicz_plyty_dla_szafki();

        public List<Plyta> wyznacz_spod_boki_stezenia()
        {
            List<Plyta> lista_spod_boki_stezenia = new List<Plyta>();

            lista_spod_boki_stezenia.Add(wyznacz_spod());
            lista_spod_boki_stezenia.AddRange(wyznacz_boki());
            lista_spod_boki_stezenia.AddRange(wyznacz_stezenia(ilosc_stezen));

            return lista_spod_boki_stezenia;
        }

        public Plyta wyznacz_spod()
        {
            Plyta spod = new Plyta(grubosc_plyty_szafki, szerokosc_szafki-2* grubosc_plyty_szafki, glebokosc_szafki,true, false, true, true);

            return spod;
        }

        public List<Plyta> wyznacz_boki()
        {
            List<Plyta> boki = new List<Plyta>();

            for (int i = 0; i < 2; i++)
                boki.Add(wyznacz_bok());

            return boki;
        }

        public Plyta wyznacz_bok()
        {
            Plyta bok = new Plyta( grubosc_plyty_szafki, wysokosc_szafki, glebokosc_szafki, true, false, true, false);

            return bok;
        }

        public List<Plyta> wyznacz_stezenia(int ilosc_stezen)
        {
            List<Plyta> lista_stezen = new List<Plyta>();

            for (int i = 0; i < 3; i++)
            {
                lista_stezen.Add(wyznacz_stezenie());
            }

            return lista_stezen;
        }

        public Plyta wyznacz_stezenie()
        {
            Plyta stezenie = new Plyta( grubosc_plyty_szafki, szerokosc_szafki - 2*grubosc_plyty_szafki, wysokosc_stezenia, true, true, false, false);

            return stezenie;
        }

    }
}
