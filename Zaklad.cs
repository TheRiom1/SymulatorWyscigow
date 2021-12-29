using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienNaWyscigach
{
    public class Zaklad 
    {

        public int IloscGotowki; //postawione pieniadze
        public int Kon; //numer konia wyścigowego
        public Gracz AktualnyGracz; //aktualny gracz
       
        //konstruktor przyjmujacy trzy parametry, ustawia pola Kon, IloscGotowki, AktualnyGracz, 
        public Zaklad(int Amount, int Dog, Gracz Bettor)
        {
            this.IloscGotowki = Amount;
            this.Kon = Dog;
            this.AktualnyGracz = Bettor;
        }

        public string GetDescription() //opis do zakładów
        {
            //jezeli IloscGotowki wieksza od zera informuje o szczegolach zakladu, jesli jest rowna zero , zaklad nie zostal postawiony
            if (IloscGotowki == 0)
                return AktualnyGracz.Name + " nie obstawił zakładu";
            else
                return AktualnyGracz.Name + " obstawil " + IloscGotowki + " zlotych na psa numer " + Kon;
        }

        //pobiera jako parametr zwyciezce wyscigu i zwraca odpowiednie kwoty w zależnosci od wygranej lub przegranej
        public int PayOut(int Winner)
        {
            if (Winner == Kon)
                return IloscGotowki;
            else
                return (0 - IloscGotowki);
        }
    }
}
