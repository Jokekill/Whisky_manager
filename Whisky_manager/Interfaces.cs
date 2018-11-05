using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Whisky_manager
{
    interface IKontroler
    {
        bool Vyhodnot(string prikaz);
    }

    interface IModel
    {
        Uzivatel GetUzivatel(int ID);
        Uzivatel GetUzivatel(string jmeno);

        Lahev GetLahev(int ID);
        Lahev GetLahev(string jmeno);

        bool OdstranUzivatele(Uzivatel u);
        bool OdstranLahev(Lahev l);

        bool PridejUzivatele(Uzivatel u);
        bool PridejLahev(Lahev l);

        bool UlozSe();
    }

    interface IVisualizer
    {
        bool Ukaz(object ojb, TextWriter output);
    }
}
