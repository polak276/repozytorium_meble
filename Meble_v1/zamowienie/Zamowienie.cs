using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Meble_v_1.meble;
using static Meble_v_1.meble.Szafka;

namespace Meble_v_1.Zamowienie

{
    public class Zamowienie : Dodawanie_szafek
    {

        public string nazwa { get; set; }
        List<Szafka> lista_szafek;

        public Zamowienie( string otrzymana_nazwa )
        {
            nazwa = otrzymana_nazwa;

            //MessageBox.Show("tworze nowe zamowienie");

            lista_szafek = new List<Szafka>();
        }

        ~Zamowienie()
        {
            //MessageBox.Show("kasuje te zamowienie  ");
        }

        public Szafka dodaj_szafke(rodzaje_szafek typ_szafki )
        {
            Szafka nowa_szafka;

            switch (typ_szafki)
            {
                case 0:
                    nowa_szafka = dodaj_szafke_podblatowa_standardowa();
                    return nowa_szafka;

                default:
                    return null; //tu zwrocic wyjatek
            }

        }

        public Podblatowa_standard dodaj_szafke_podblatowa_standardowa()
        {
            Podblatowa_standard szafka_podblatowa = new Podblatowa_standard( 1,2,3,4 ); //potem oczywiscie zmodyfikowac z podawanych pol

            return szafka_podblatowa;
        }
    }
}
