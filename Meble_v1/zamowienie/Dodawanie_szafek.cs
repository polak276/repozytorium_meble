using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meble_v_1.meble;
using static Meble_v_1.meble.Szafka;

namespace Meble_v_1.Zamowienie
{
    interface Dodawanie_szafek
    {

        Szafka dodaj_szafke(rodzaje_szafek szafka );
        Podblatowa_standard dodaj_szafke_podblatowa_standardowa();

    }
}
