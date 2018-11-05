using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whisky_manager
{
    //
    //Model
    //

    

    struct Uzivatel
    {
        int ID;
        string jmeno;
        List<Polozka> nezaplaceno;
        int kredit;
        int neautorizovanyKredit;
        string email;
    }

    struct Polozka
    {
        int ID;
        int ID_lahev;
        int ID_uzivatel;
        DateTime casNakupu;
        int mnozstvi_ml;
        bool zaplaceno;
        int cena;
    }

    struct Lahev
    {
        int ID;
        string jmeno;
        int stari;
        int cena_20ml_zakaznik;
        int cena_20ml_VIP;
        int cena_flasky;
        int zbyleMnozstvi_ml;
    }
}
